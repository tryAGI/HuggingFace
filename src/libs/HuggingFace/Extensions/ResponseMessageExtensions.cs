namespace tryAGI.OpenAI;

/// <summary>
/// 
/// </summary>
public static class ResponseMessageExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static ChatCompletionRequestMessage AsRequestMessage(this ChatCompletionResponseMessage message)
    {
        message = message ?? throw new ArgumentNullException(nameof(message));
        
        return new ChatCompletionRequestMessage
        {
            Role = message.Role switch
            {
                ChatCompletionResponseMessageRole.System => ChatCompletionRequestMessageRole.System,
                ChatCompletionResponseMessageRole.User => ChatCompletionRequestMessageRole.User,
                ChatCompletionResponseMessageRole.Assistant => ChatCompletionRequestMessageRole.Assistant,
                ChatCompletionResponseMessageRole.Function => ChatCompletionRequestMessageRole.Function,
                _ => throw new ArgumentOutOfRangeException(nameof(message), $"Unknown role: {message.Role}"),
            },
            Content = message.Content ?? string.Empty,
            Function_call = message.Function_call != null ?
                new Function_call
                {
                    Arguments = message.Function_call.Arguments ?? string.Empty,
                    Name = message.Function_call.Name ?? string.Empty,
                }
                : null,
        };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="response"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static ChatCompletionResponseMessage GetFirstChoiceMessage(this CreateChatCompletionResponse response)
    {
        response = response ?? throw new ArgumentNullException(nameof(response));
        
        return response.Choices.First().Message ??
               throw new ArgumentException("No message in the first choice.");
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="response"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static ChatCompletionStreamResponseDelta GetFirstChoiceDelta(this CreateChatCompletionStreamResponse response)
    {
        response = response ?? throw new ArgumentNullException(nameof(response));
        
        return response.Choices.First().Delta ??
               throw new ArgumentException("No delta in the first choice.");
    }
}