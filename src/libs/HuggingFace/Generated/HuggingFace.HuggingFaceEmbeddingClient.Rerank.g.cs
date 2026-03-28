
#nullable enable

namespace HuggingFace
{
    public partial class HuggingFaceEmbeddingClient
    {
        partial void PrepareRerankArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::HuggingFace.RerankRequest request);
        partial void PrepareRerankRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::HuggingFace.RerankRequest request);
        partial void ProcessRerankResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRerankResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Ranks. Returns a 424 status code if the model is not a Sequence Classification model with<br/>
        /// a single class.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::HuggingFace.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.Rank>> RerankAsync(

            global::HuggingFace.RerankRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareRerankArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::HuggingFace.PathBuilder(
                path: "/rerank",
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
            PrepareRerankRequest(
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
            ProcessRerankResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Batch is empty
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::HuggingFace.ErrorResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::HuggingFace.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::HuggingFace.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::HuggingFace.ApiException<global::HuggingFace.ErrorResponse>(
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
                global::HuggingFace.ErrorResponse? __value_413 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_413 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_413 = global::HuggingFace.ErrorResponse.FromJson(__content_413, JsonSerializerContext);
                    }
                    else
                    {
                        __content_413 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_413 = global::HuggingFace.ErrorResponse.FromJson(__content_413, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_413 = __ex;
                }

                throw new global::HuggingFace.ApiException<global::HuggingFace.ErrorResponse>(
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
            // Rerank Error
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
                ProcessRerankResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        (global::System.Collections.Generic.IList<global::HuggingFace.Rank>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::HuggingFace.Rank>), JsonSerializerContext) ??
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
                        (global::System.Collections.Generic.IList<global::HuggingFace.Rank>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::HuggingFace.Rank>), JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Get Ranks. Returns a 424 status code if the model is not a Sequence Classification model with<br/>
        /// a single class.
        /// </summary>
        /// <param name="query">
        /// Example: What is Deep Learning?
        /// </param>
        /// <param name="rawScores">
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="returnText">
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="texts">
        /// Example: [Deep Learning is ...]
        /// </param>
        /// <param name="truncate">
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="truncationDirection">
        /// Default Value: right
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.Rank>> RerankAsync(
            string query,
            global::System.Collections.Generic.IList<string> texts,
            bool? rawScores = default,
            bool? returnText = default,
            bool? truncate = default,
            global::HuggingFace.TruncationDirection? truncationDirection = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::HuggingFace.RerankRequest
            {
                Query = query,
                RawScores = rawScores,
                ReturnText = returnText,
                Texts = texts,
                Truncate = truncate,
                TruncationDirection = truncationDirection,
            };

            return await RerankAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}