
#nullable enable

namespace HuggingFace
{
    public partial class HuggingFaceInferenceClient
    {


        private static readonly global::HuggingFace.EndPointSecurityRequirement s_ChatCompletionsAsStreamSecurityRequirement0 =
            new global::HuggingFace.EndPointSecurityRequirement
            {
                Authorizations = new global::HuggingFace.EndPointAuthorizationRequirement[]
                {                    new global::HuggingFace.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::HuggingFace.EndPointSecurityRequirement[] s_ChatCompletionsAsStreamSecurityRequirements =
            new global::HuggingFace.EndPointSecurityRequirement[]
            {                s_ChatCompletionsAsStreamSecurityRequirement0,
            };
        partial void PrepareChatCompletionsAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::HuggingFace.ChatRequest request);
        partial void PrepareChatCompletionsAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::HuggingFace.ChatRequest request);
        partial void ProcessChatCompletionsAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Generate tokens
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::HuggingFace.ChatCompletionChunk> ChatCompletionsAsStreamAsync(

            global::HuggingFace.ChatRequest request,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::HuggingFace.ChatRequest
            {
                FrequencyPenalty = request.FrequencyPenalty,
                LogitBias = request.LogitBias,
                Logprobs = request.Logprobs,
                MaxTokens = request.MaxTokens,
                Messages = request.Messages,
                Model = request.Model,
                N = request.N,
                PresencePenalty = request.PresencePenalty,
                ResponseFormat = request.ResponseFormat,
                Seed = request.Seed,
                Stop = request.Stop,
                Stream = true,
                StreamOptions = request.StreamOptions,
                Temperature = request.Temperature,
                ToolChoice = request.ToolChoice,
                ToolPrompt = request.ToolPrompt,
                Tools = request.Tools,
                TopLogprobs = request.TopLogprobs,
                TopP = request.TopP,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareChatCompletionsAsStreamArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::HuggingFace.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ChatCompletionsAsStreamSecurityRequirements,
                operationName: "ChatCompletionsAsStreamAsync");

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: "/v1/chat/completions",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareChatCompletionsAsStreamRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessChatCompletionsAsStreamResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                string? __content = null;
                try
                {
                    __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);
                }
                catch (global::System.Exception)
                {
                }

                throw new global::HuggingFace.ApiException(
                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            using var __stream = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                cancellationToken
#endif
            ).ConfigureAwait(false);

            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                .Create(__stream).EnumerateAsync(cancellationToken))
            {
                var __content = __sseEvent.Data;
                if (__content == "[DONE]")
                {
                    yield break;
                }

                var __streamedResponse = global::HuggingFace.ChatCompletionChunk.FromJson(__content, JsonSerializerContext) ??
                                       throw new global::HuggingFace.ApiException(
                                           message: $"Response deserialization failed for \"{__content}\" ",
                                           statusCode: __response.StatusCode)
                                       {
                                           ResponseBody = __content,
                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                               __response.Headers,
                                               h => h.Key,
                                               h => h.Value),
                                       };

                yield return __streamedResponse;
            }
        }
        /// <summary>
        /// Generate tokens
        /// </summary>
        /// <param name="frequencyPenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far,<br/>
        /// decreasing the model's likelihood to repeat the same line verbatim.<br/>
        /// Example: 1.0
        /// </param>
        /// <param name="logitBias">
        /// UNUSED<br/>
        /// Modify the likelihood of specified tokens appearing in the completion. Accepts a JSON object that maps tokens<br/>
        /// (specified by their token ID in the tokenizer) to an associated bias value from -100 to 100. Mathematically,<br/>
        /// the bias is added to the logits generated by the model prior to sampling. The exact effect will vary per model,<br/>
        /// but values between -1 and 1 should decrease or increase likelihood of selection; values like -100 or 100 should<br/>
        /// result in a ban or exclusive selection of the relevant token.
        /// </param>
        /// <param name="logprobs">
        /// Whether to return log probabilities of the output tokens or not. If true, returns the log probabilities of each<br/>
        /// output token returned in the content of message.<br/>
        /// Example: false
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens that can be generated in the chat completion.<br/>
        /// Default Value: 1024<br/>
        /// Example: 32
        /// </param>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.<br/>
        /// Example: [{"role": "user", "content": "What is Deep Learning?"}]
        /// </param>
        /// <param name="model">
        /// [UNUSED] ID of the model to use. See the model endpoint compatibility table for details on which models work with the Chat API.<br/>
        /// Example: mistralai/Mistral-7B-Instruct-v0.2
        /// </param>
        /// <param name="n">
        /// UNUSED<br/>
        /// How many chat completion choices to generate for each input message. Note that you will be charged based on the<br/>
        /// number of generated tokens across all of the choices. Keep n as 1 to minimize costs.<br/>
        /// Example: 2
        /// </param>
        /// <param name="presencePenalty">
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far,<br/>
        /// increasing the model's likelihood to talk about new topics<br/>
        /// Example: 0.1F
        /// </param>
        /// <param name="responseFormat">
        /// Default Value: null
        /// </param>
        /// <param name="seed">
        /// Example: 42
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating further tokens.<br/>
        /// Example: null
        /// </param>
        /// <param name="streamOptions"></param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while<br/>
        /// lower values like 0.2 will make it more focused and deterministic.<br/>
        /// We generally recommend altering this or `top_p` but not both.<br/>
        /// Example: 1F
        /// </param>
        /// <param name="toolChoice">
        /// Default Value: auto
        /// </param>
        /// <param name="toolPrompt">
        /// A prompt to be appended before the tools<br/>
        /// Example: Given the functions available, please respond with a JSON for a function call with its proper arguments that best answers the given prompt. Respond in the format {name: function name, parameters: dictionary of argument name and its value}.Do not use variables.
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of<br/>
        /// functions the model may generate JSON inputs for.<br/>
        /// Example: null
        /// </param>
        /// <param name="topLogprobs">
        /// An integer between 0 and 5 specifying the number of most likely tokens to return at each token position, each with<br/>
        /// an associated log probability. logprobs must be set to true if this parameter is used.<br/>
        /// Example: 5
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the<br/>
        /// tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.<br/>
        /// Example: 0.95F
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::HuggingFace.ChatCompletionChunk> ChatCompletionsAsStreamAsync(
            global::System.Collections.Generic.IList<global::HuggingFace.Message> messages,
            float? frequencyPenalty = default,
            global::System.Collections.Generic.IList<float>? logitBias = default,
            bool? logprobs = default,
            int? maxTokens = default,
            string? model = default,
            int? n = default,
            float? presencePenalty = default,
            global::HuggingFace.GrammarType? responseFormat = default,
            long? seed = default,
            global::System.Collections.Generic.IList<string>? stop = default,
            global::HuggingFace.StreamOptions? streamOptions = default,
            float? temperature = default,
            global::HuggingFace.ToolChoice? toolChoice = default,
            string? toolPrompt = default,
            global::System.Collections.Generic.IList<global::HuggingFace.Tool>? tools = default,
            int? topLogprobs = default,
            float? topP = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::HuggingFace.ChatRequest
            {
                FrequencyPenalty = frequencyPenalty,
                LogitBias = logitBias,
                Logprobs = logprobs,
                MaxTokens = maxTokens,
                Messages = messages,
                Model = model,
                N = n,
                PresencePenalty = presencePenalty,
                ResponseFormat = responseFormat,
                Seed = seed,
                Stop = stop,
                Stream = true,
                StreamOptions = streamOptions,
                Temperature = temperature,
                ToolChoice = toolChoice,
                ToolPrompt = toolPrompt,
                Tools = tools,
                TopLogprobs = topLogprobs,
                TopP = topP,
            };

            var __enumerable = ChatCompletionsAsStreamAsync(
                request: __request,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}