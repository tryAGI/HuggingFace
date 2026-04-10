#nullable enable

namespace HuggingFace
{
    public partial interface IHuggingFaceInferenceClient
    {
        /// <summary>
        /// Generate tokens
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::HuggingFace.Chunk> CompletionsAsStreamAsync(

            global::HuggingFace.CompletionRequest request,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate tokens
        /// </summary>
        /// <param name="frequencyPenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far,<br/>
        /// decreasing the model's likelihood to repeat the same line verbatim.<br/>
        /// Example: 1.0
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens that can be generated in the chat completion.<br/>
        /// Default Value: 1024<br/>
        /// Example: 32
        /// </param>
        /// <param name="model">
        /// UNUSED<br/>
        /// ID of the model to use. See the model endpoint compatibility table for details on which models work with the Chat API.<br/>
        /// Example: mistralai/Mistral-7B-Instruct-v0.2
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="repetitionPenalty"></param>
        /// <param name="seed">
        /// Example: 42
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating further tokens.<br/>
        /// Example: null
        /// </param>
        /// <param name="suffix">
        /// The text to append to the prompt. This is useful for completing sentences or generating a paragraph of text.<br/>
        /// please see the completion_template field in the model's tokenizer_config.json file for completion template.
        /// </param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while<br/>
        /// lower values like 0.2 will make it more focused and deterministic. We generally recommend altering this or `top_p` but not both.<br/>
        /// Example: 1F
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the<br/>
        /// tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.<br/>
        /// Example: 0.95F
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::HuggingFace.Chunk> CompletionsAsStreamAsync(
            global::System.Collections.Generic.IList<string> prompt,
            float? frequencyPenalty = default,
            int? maxTokens = default,
            string? model = default,
            float? repetitionPenalty = default,
            long? seed = default,
            global::System.Collections.Generic.IList<string>? stop = default,
            string? suffix = default,
            float? temperature = default,
            float? topP = default,
            global::HuggingFace.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}