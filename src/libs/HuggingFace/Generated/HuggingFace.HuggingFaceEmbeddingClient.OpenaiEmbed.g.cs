
#nullable enable

namespace HuggingFace
{
    public partial class HuggingFaceEmbeddingClient
    {
        partial void PrepareOpenaiEmbedArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::HuggingFace.OpenAICompatRequest request);
        partial void PrepareOpenaiEmbedRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::HuggingFace.OpenAICompatRequest request);
        partial void ProcessOpenaiEmbedResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOpenaiEmbedResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// OpenAI compatible route. Returns a 424 status code if the model is not an embedding model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.OpenAICompatResponse> OpenaiEmbedAsync(

            global::HuggingFace.OpenAICompatRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareOpenaiEmbedArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: "/v1/embeddings",
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
            PrepareOpenaiEmbedRequest(
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
            ProcessOpenaiEmbedResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Batch is empty
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::HuggingFace.OpenAICompatErrorResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::HuggingFace.OpenAICompatErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = await global::HuggingFace.OpenAICompatErrorResponse.FromJsonStreamAsync(__contentStream_400, JsonSerializerContext).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::HuggingFace.ApiException<global::HuggingFace.OpenAICompatErrorResponse>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Batch size error
            if ((int)__response.StatusCode == 413)
            {
                string? __content_413 = null;
                global::System.Exception? __exception_413 = null;
                global::HuggingFace.OpenAICompatErrorResponse? __value_413 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_413 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_413 = global::HuggingFace.OpenAICompatErrorResponse.FromJson(__content_413, JsonSerializerContext);
                    }
                    else
                    {
                        var __contentStream_413 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_413 = await global::HuggingFace.OpenAICompatErrorResponse.FromJsonStreamAsync(__contentStream_413, JsonSerializerContext).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_413 = __ex;
                }

                throw new global::HuggingFace.ApiException<global::HuggingFace.OpenAICompatErrorResponse>(
                    message: __content_413 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_413,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_413,
                    ResponseObject = __value_413,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Tokenization error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::HuggingFace.OpenAICompatErrorResponse? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::HuggingFace.OpenAICompatErrorResponse.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = await global::HuggingFace.OpenAICompatErrorResponse.FromJsonStreamAsync(__contentStream_422, JsonSerializerContext).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::HuggingFace.ApiException<global::HuggingFace.OpenAICompatErrorResponse>(
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
            // Embedding Error
            if ((int)__response.StatusCode == 424)
            {
                string? __content_424 = null;
                global::System.Exception? __exception_424 = null;
                global::HuggingFace.OpenAICompatErrorResponse? __value_424 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_424 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_424 = global::HuggingFace.OpenAICompatErrorResponse.FromJson(__content_424, JsonSerializerContext);
                    }
                    else
                    {
                        var __contentStream_424 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_424 = await global::HuggingFace.OpenAICompatErrorResponse.FromJsonStreamAsync(__contentStream_424, JsonSerializerContext).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_424 = __ex;
                }

                throw new global::HuggingFace.ApiException<global::HuggingFace.OpenAICompatErrorResponse>(
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
                global::HuggingFace.OpenAICompatErrorResponse? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::HuggingFace.OpenAICompatErrorResponse.FromJson(__content_429, JsonSerializerContext);
                    }
                    else
                    {
                        var __contentStream_429 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = await global::HuggingFace.OpenAICompatErrorResponse.FromJsonStreamAsync(__contentStream_429, JsonSerializerContext).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::HuggingFace.ApiException<global::HuggingFace.OpenAICompatErrorResponse>(
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
                ProcessOpenaiEmbedResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::HuggingFace.OpenAICompatResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::HuggingFace.OpenAICompatResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::HuggingFace.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }

        /// <summary>
        /// OpenAI compatible route. Returns a 424 status code if the model is not an embedding model.
        /// </summary>
        /// <param name="dimensions">
        /// Default Value: null<br/>
        /// Example: null
        /// </param>
        /// <param name="encodingFormat">
        /// Default Value: float
        /// </param>
        /// <param name="input"></param>
        /// <param name="model">
        /// Example: null
        /// </param>
        /// <param name="user">
        /// Example: null
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::HuggingFace.OpenAICompatResponse> OpenaiEmbedAsync(
            global::HuggingFace.Input input,
            int? dimensions = default,
            global::HuggingFace.EncodingFormat? encodingFormat = default,
            string? model = default,
            string? user = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::HuggingFace.OpenAICompatRequest
            {
                Dimensions = dimensions,
                EncodingFormat = encodingFormat,
                Input = input,
                Model = model,
                User = user,
            };

            return await OpenaiEmbedAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}