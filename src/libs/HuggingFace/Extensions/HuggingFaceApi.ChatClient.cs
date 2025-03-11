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
        AppendRole(ChatRole.Assistant);

        void AppendRole(ChatRole role) => prompt.Append("<|").Append(role.Value).Append("|>");

        var requestOptions = new GenerateTextRequestOptions()
        {
            UseCache = options?.AdditionalProperties?[nameof(GenerateTextRequestOptions.UseCache)],
            WaitForModel = options?.AdditionalProperties?[nameof(GenerateTextRequestOptions.WaitForModel)],
        };

        var requestParameters = new GenerateTextRequestParameters()
        {
            ReturnFullText = false,

            MaxNewTokens = options?.MaxOutputTokens,
            Temperature = options?.Temperature,
            TopP = options?.TopP,
            TopK = options?.TopK,

            DoSample = options?.AdditionalProperties?[nameof(GenerateTextRequestParameters.DoSample)],
            MaxTime = options?.AdditionalProperties?.TryGetValue(nameof(GenerateTextRequestParameters.MaxTime), out double maxTime) is true ? maxTime : null,
            NumReturnSequences = options?.AdditionalProperties?.TryGetValue(nameof(GenerateTextRequestParameters.NumReturnSequences), out int numReturnSequences) is true ? numReturnSequences : null,
            RepetitionPenalty = options?.AdditionalProperties?.TryGetValue(nameof(GenerateTextRequestParameters.RepetitionPenalty), out double repetitionPenalty) is true ? repetitionPenalty : null,
        };;

        var request = new GenerateTextRequest()
        {
            Inputs = prompt.ToString(),
            Options = requestOptions,
            Parameters = requestParameters,
        };

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