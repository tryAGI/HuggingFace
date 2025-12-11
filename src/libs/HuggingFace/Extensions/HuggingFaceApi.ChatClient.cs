using Microsoft.Extensions.AI;
using System.Runtime.CompilerServices;
using System.Text;

namespace HuggingFace;

public sealed partial class HuggingFaceClient : IChatClient
{
    private ChatClientMetadata? _metadata;

    /// <inheritdoc />
    object? IChatClient.GetService(Type serviceType, object? serviceKey)
    {
        return
            serviceKey is not null ? null :
            serviceType == typeof(ChatClientMetadata) ? (_metadata ??= new(nameof(HuggingFaceClient), this.BaseUri)) :
            serviceType?.IsInstanceOfType(this) is true ? this :
            null;
    }

    /// <inheritdoc />
    async Task<ChatResponse> IChatClient.GetResponseAsync(IEnumerable<ChatMessage> messages, ChatOptions? options, CancellationToken cancellationToken)
    {
        StringBuilder prompt = new();
        foreach (ChatMessage message in messages)
        {
            AppendRole(message.Role);
            foreach (AIContent content in message.Contents)
            {
                if (content is TextContent textContent)
                {
                    prompt.Append(textContent.Text);
                }
            }
            prompt.AppendLine();
        }

        if (!string.IsNullOrWhiteSpace(options?.Instructions))
        {
            AppendRole(ChatRole.System);
            prompt.Append(options?.Instructions).AppendLine();
        }

        AppendRole(ChatRole.Assistant);

        void AppendRole(ChatRole role) => prompt.Append("<|").Append(role.Value).Append("|>");

        GenerateTextRequest? request = options?.RawRepresentationFactory?.Invoke(this) as GenerateTextRequest;
        if (request is not null)
        {
            request.Inputs = prompt.ToString();
        }
        else
        {
            request = new() { Inputs = prompt.ToString() };
        }

        var requestParameters = request.Parameters ??= new();
        requestParameters.ReturnFullText ??= false;
        requestParameters.MaxNewTokens ??= options?.MaxOutputTokens;
        requestParameters.Temperature ??= options?.Temperature;
        requestParameters.TopP ??= options?.TopP;
        requestParameters.TopK ??= options?.TopK;

        IList<GenerateTextResponseValue> response = await this.GenerateTextAsync(
            options?.ModelId ?? string.Empty,
            request, cancellationToken).ConfigureAwait(false);

        return new(response.Select(static r => new ChatMessage(ChatRole.Assistant, r.GeneratedText)
        {
            AdditionalProperties = new(r.AdditionalProperties!),
            RawRepresentation = r,
        }).ToList())
        {
            CreatedAt = DateTime.UtcNow,
        };
    }

    /// <inheritdoc />
    async IAsyncEnumerable<ChatResponseUpdate> IChatClient.GetStreamingResponseAsync(
        IEnumerable<ChatMessage> messages, ChatOptions? options, [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        ChatResponse response = await ((IChatClient)this).GetResponseAsync(messages, options, cancellationToken).ConfigureAwait(false);

        foreach (var update in response.ToChatResponseUpdates())
        {
            yield return update;
        }
    }
}