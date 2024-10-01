
#nullable enable

namespace HuggingFace
{
    public sealed partial class HuggingFaceApi
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingBearer(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _authorization = new global::HuggingFace.EndPointAuthorization
            {
                Name = "Bearer",
                Value = apiKey,
            };
        }
    }
}