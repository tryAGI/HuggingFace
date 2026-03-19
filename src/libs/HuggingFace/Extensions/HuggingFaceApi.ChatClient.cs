using Microsoft.Extensions.AI;
using System.Runtime.CompilerServices;
using System.Text.Json;

// ReSharper disable once CheckNamespace

namespace HuggingFace;

public partial class HuggingFaceInferenceClient : IChatClient
{
    private ChatClientMetadata? _metadata;

    /// <inheritdoc />
    object? IChatClient.GetService(Type serviceType, object? serviceKey)
    {
        return
            serviceKey is not null ? null :
            serviceType == typeof(ChatClientMetadata) ? (_metadata ??= new(nameof(HuggingFaceInferenceClient), BaseUri)) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    async Task<ChatResponse> IChatClient.GetResponseAsync(
        IEnumerable<ChatMessage> messages, ChatOptions? options, CancellationToken cancellationToken)
    {
        var request = CreateChatRequest(messages, options);

        var response = await ChatCompletionsAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false);

        var choice = response.Choices.Count > 0 ? response.Choices[0] : null;

        ChatMessage responseMessage = new()
        {
            Role = ChatRole.Assistant,
            RawRepresentation = response,
        };

        if (choice is not null)
        {
            var message = choice.Message;
            if (message.IsText && message.Text is { } textMsg)
            {
                responseMessage.Contents.Add(new TextContent(textMsg.Content) { RawRepresentation = message });
            }
            else if (message.IsToolCall && message.ToolCall is { } toolCallMsg)
            {
                foreach (var tc in toolCallMsg.ToolCalls)
                {
                    var args = tc.Function.Arguments is JsonElement je
                        ? je.Deserialize<Dictionary<string, object?>>()
                        : null;
                    responseMessage.Contents.Add(new FunctionCallContent(tc.Id, tc.Function.Name, args)
                    {
                        RawRepresentation = tc
                    });
                }
            }
        }

        var chatResponse = new ChatResponse(responseMessage)
        {
            RawRepresentation = response,
            ResponseId = response.Id,
            ModelId = response.Model,
            FinishReason = choice?.FinishReason switch
            {
                "stop" => ChatFinishReason.Stop,
                "length" => ChatFinishReason.Length,
                "tool_calls" => ChatFinishReason.ToolCalls,
                _ => choice?.FinishReason is { } fr ? new ChatFinishReason(fr) : null,
            },
        };

        if (response.Usage is { } u)
        {
            chatResponse.Usage = new()
            {
                InputTokenCount = u.PromptTokens,
                OutputTokenCount = u.CompletionTokens,
                TotalTokenCount = u.TotalTokens,
            };
        }

        return chatResponse;
    }

    async IAsyncEnumerable<ChatResponseUpdate> IChatClient.GetStreamingResponseAsync(
        IEnumerable<ChatMessage> messages, ChatOptions? options, [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        var request = CreateChatRequest(messages, options);

        await foreach (var chunk in ChatCompletionsAsStreamAsync(request, cancellationToken: cancellationToken).ConfigureAwait(false))
        {
            var choice = chunk.Choices.Count > 0 ? chunk.Choices[0] : null;
            var update = new ChatResponseUpdate
            {
                ResponseId = chunk.Id,
                ModelId = chunk.Model,
                RawRepresentation = chunk,
                Role = ChatRole.Assistant,
                FinishReason = choice?.FinishReason switch
                {
                    "stop" => ChatFinishReason.Stop,
                    "length" => ChatFinishReason.Length,
                    "tool_calls" => ChatFinishReason.ToolCalls,
                    _ => choice?.FinishReason is { } fr ? new ChatFinishReason(fr) : null,
                },
            };

            if (choice is not null)
            {
                var delta = choice.Delta;
                if (delta.IsTextMessage && delta.TextMessage is { } textMsg)
                {
                    update.Contents.Add(new TextContent(textMsg.Content) { RawRepresentation = delta });
                }
                else if (delta.IsToolCall && delta.ToolCall is { } toolCallDelta)
                {
                    foreach (var tc in toolCallDelta.ToolCalls)
                    {
                        var args = !string.IsNullOrEmpty(tc.Function.Arguments)
                            ? tc.Function.Arguments
                            : null;
                        update.Contents.Add(new FunctionCallContent(tc.Id, tc.Function.Name ?? string.Empty, args is not null
                            ? JsonSerializer.Deserialize<Dictionary<string, object?>>(args)
                            : null)
                        {
                            RawRepresentation = tc
                        });
                    }
                }
            }

            if (chunk.Usage is { } u)
            {
                update.Contents.Add(new UsageContent(new()
                {
                    InputTokenCount = u.PromptTokens,
                    OutputTokenCount = u.CompletionTokens,
                    TotalTokenCount = u.TotalTokens,
                }));
            }

            yield return update;
        }
    }

    private static ChatRequest CreateChatRequest(IEnumerable<ChatMessage> chatMessages, ChatOptions? options)
    {
        var messages = new List<Message>();
        foreach (var chatMessage in chatMessages)
        {
            var role = chatMessage.Role == ChatRole.System ? "system"
                : chatMessage.Role == ChatRole.Assistant ? "assistant"
                : chatMessage.Role == ChatRole.Tool ? "tool"
                : "user";

            // Check for function call contents (assistant tool call messages)
            var functionCalls = chatMessage.Contents.OfType<FunctionCallContent>().ToList();
            if (functionCalls.Count > 0)
            {
                var toolCalls = functionCalls.Select(fc => new ToolCall
                {
                    Id = fc.CallId,
                    Type = "function",
                    Function = new FunctionDefinition
                    {
                        Name = fc.Name,
                        Arguments = fc.Arguments ?? new Dictionary<string, object?>(),
                    },
                }).ToList();

                messages.Add(new Message(
                    value1: new MessageBody(new MessageBodyVariant2(toolCalls)),
                    value2: new MessageVariant2(role: role, name: null)));
                continue;
            }

            // Check for function result contents (tool response messages)
            var functionResults = chatMessage.Contents.OfType<FunctionResultContent>().ToList();
            if (functionResults.Count > 0)
            {
                foreach (var fr in functionResults)
                {
                    var text = fr.Result?.ToString() ?? string.Empty;
                    var textMessage = new TextMessage
                    {
                        Content = text,
                        Role = role,
                        ToolCallId = fr.CallId,
                    };
                    messages.Add(new Message(
                        value1: new MessageBody(new MessageBodyVariant1(new MessageContent(text))),
                        value2: new MessageVariant2(role: role, name: null)));
                }
                continue;
            }

            // Text content
            var content = string.Concat(chatMessage.Contents.OfType<TextContent>().Select(tc => tc.Text));
            messages.Add(new Message(
                value1: new MessageBody(new MessageBodyVariant1(new MessageContent(content))),
                value2: new MessageVariant2(role: role, name: null)));
        }

        var request = new ChatRequest
        {
            Model = options?.ModelId,
            Messages = messages,
            MaxTokens = options?.MaxOutputTokens,
            Temperature = options?.Temperature,
            TopP = options?.TopP,
            Stop = options?.StopSequences?.ToList(),
            Stream = false,
        };

        if (options?.Tools is { Count: > 0 } aiTools)
        {
            request.Tools = aiTools.OfType<AIFunction>().Select(f => new Tool
            {
                Type = "function",
                Function = new FunctionDefinition
                {
                    Name = f.Name,
                    Description = f.Description,
                    Arguments = f.JsonSchema,
                },
            }).ToList();
        }

        return request;
    }
}
