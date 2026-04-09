
#nullable enable

namespace HuggingFace
{
    public partial interface IHuggingFaceInferenceClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}