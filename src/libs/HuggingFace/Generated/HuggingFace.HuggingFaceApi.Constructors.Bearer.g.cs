
#nullable enable

namespace HuggingFace
{
    public sealed partial class HuggingFaceApi
    {
        /// <inheritdoc cref="HuggingFaceApi(global::System.Net.Http.HttpClient?, global::System.Uri?)"/>
        public HuggingFaceApi(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null) : this(httpClient, baseUri)
        {
            AuthorizeUsingBearer(apiKey);
        }
    }
}