
#nullable enable

namespace HuggingFace
{
    public partial class HuggingFaceInferenceClient
    {
        partial void PrepareCompletionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::HuggingFace.CompletionRequest request);
        partial void PrepareCompletionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::HuggingFace.CompletionRequest request);
        partial void ProcessCompletionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCompletionsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);


        /// <summary>
        /// Generate tokens
        /// </summary>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.CompletionFinal> CompletionsAsync(

            global::HuggingFace.CompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));


            request = new global::HuggingFace.CompletionRequest
            {
                FrequencyPenalty = request.FrequencyPenalty,
                MaxTokens = request.MaxTokens,
                Model = request.Model,
                Prompt = request.Prompt,
                RepetitionPenalty = request.RepetitionPenalty,
                Seed = request.Seed,
                Stop = request.Stop,
                Stream = false,
                Suffix = request.Suffix,
                Temperature = request.Temperature,
                TopP = request.TopP,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCompletionsArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: "/v1/completions",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
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
            PrepareCompletionsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCompletionsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Input validation error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::HuggingFace.ErrorResponse? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::HuggingFace.ErrorResponse.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::HuggingFace.ErrorResponse.FromJson(__content_422, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::HuggingFace.ApiException<global::HuggingFace.ErrorResponse>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Generation Error
            if ((int)__response.StatusCode == 424)
            {
                string? __content_424 = null;
                global::System.Exception? __exception_424 = null;
                global::HuggingFace.ErrorResponse? __value_424 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_424 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_424 = global::HuggingFace.ErrorResponse.FromJson(__content_424, JsonSerializerContext);
                    }
                    else
                    {
                        __content_424 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_424 = global::HuggingFace.ErrorResponse.FromJson(__content_424, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_424 = __ex;
                }

                throw new global::HuggingFace.ApiException<global::HuggingFace.ErrorResponse>(
                    message: __content_424 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_424,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_424,
                    ResponseObject = __value_424,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Model is overloaded
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::HuggingFace.ErrorResponse? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::HuggingFace.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::HuggingFace.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::HuggingFace.ApiException<global::HuggingFace.ErrorResponse>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Incomplete generation
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::HuggingFace.ErrorResponse? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::HuggingFace.ErrorResponse.FromJson(__content_500, JsonSerializerContext);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::HuggingFace.ErrorResponse.FromJson(__content_500, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::HuggingFace.ApiException<global::HuggingFace.ErrorResponse>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCompletionsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::HuggingFace.CompletionFinal.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
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
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::HuggingFace.CompletionFinal.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.CompletionFinal> CompletionsAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::HuggingFace.CompletionRequest
            {
                FrequencyPenalty = frequencyPenalty,
                MaxTokens = maxTokens,
                Model = model,
                Prompt = prompt,
                RepetitionPenalty = repetitionPenalty,
                Seed = seed,
                Stop = stop,
                Stream = false,
                Suffix = suffix,
                Temperature = temperature,
                TopP = topP,
            };

            return await CompletionsAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}