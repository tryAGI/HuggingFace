
#nullable enable

namespace HuggingFace
{
    public sealed partial class HuggingFaceClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingBearer(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "Http" &&
                    __authorization.Name == "Bearer")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::HuggingFace.EndPointAuthorization
            {
                Type = "Http",
                Location = "Header",
                Name = "Bearer",
                Value = apiKey,
            });
        }
    }
}