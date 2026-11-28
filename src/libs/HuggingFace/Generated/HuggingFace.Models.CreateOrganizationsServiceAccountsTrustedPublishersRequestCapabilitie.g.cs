
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateOrganizationsServiceAccountsTrustedPublishersRequestCapabilitie
    {
        /// <summary>
        ///
        /// </summary>
        InferenceApi,
        /// <summary>
        ///
        /// </summary>
        RequestGatedRepos,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateOrganizationsServiceAccountsTrustedPublishersRequestCapabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsServiceAccountsTrustedPublishersRequestCapabilitie value)
        {
            return value switch
            {
                CreateOrganizationsServiceAccountsTrustedPublishersRequestCapabilitie.InferenceApi => "inference-api",
                CreateOrganizationsServiceAccountsTrustedPublishersRequestCapabilitie.RequestGatedRepos => "request-gated-repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsServiceAccountsTrustedPublishersRequestCapabilitie? ToEnum(string value)
        {
            return value switch
            {
                "inference-api" => CreateOrganizationsServiceAccountsTrustedPublishersRequestCapabilitie.InferenceApi,
                "request-gated-repos" => CreateOrganizationsServiceAccountsTrustedPublishersRequestCapabilitie.RequestGatedRepos,
                _ => null,
            };
        }
    }
}