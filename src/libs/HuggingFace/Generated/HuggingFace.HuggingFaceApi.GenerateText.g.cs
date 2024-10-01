
#nullable enable

namespace HuggingFace
{
    public partial class HuggingFaceApi
    {
        partial void PrepareGenerateTextArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string modelId,
            global::HuggingFace.GenerateTextRequest request);
        partial void PrepareGenerateTextRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string modelId,
            global::HuggingFace.GenerateTextRequest request);
        partial void ProcessGenerateTextResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGenerateTextResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creates a completion for the provided prompt and parameters.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GenerateTextResponseValue>> GenerateTextAsync(
            string modelId,
            global::HuggingFace.GenerateTextRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareGenerateTextArguments(
                httpClient: _httpClient,
                modelId: ref modelId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/models/{modelId}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGenerateTextRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                modelId: modelId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGenerateTextResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGenerateTextResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::HuggingFace.GenerateTextResponseValue>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::HuggingFace.GenerateTextResponseValue> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Creates a completion for the provided prompt and parameters.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="inputs">
        /// The prompt that you want to complete.<br/>
        /// Example: This is a test.
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::HuggingFace.GenerateTextResponseValue>> GenerateTextAsync(
            string modelId,
            string? inputs,
            global::HuggingFace.GenerateTextRequestParameters? parameters = default,
            global::HuggingFace.GenerateTextRequestOptions? options = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::HuggingFace.GenerateTextRequest
            {
                Inputs = inputs,
                Parameters = parameters,
                Options = options,
            };

            return await GenerateTextAsync(
                modelId: modelId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}