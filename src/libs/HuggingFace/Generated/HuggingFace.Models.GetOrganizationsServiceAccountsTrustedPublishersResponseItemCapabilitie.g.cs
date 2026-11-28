
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationsServiceAccountsTrustedPublishersResponseItemCapabilitie
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
    public static class GetOrganizationsServiceAccountsTrustedPublishersResponseItemCapabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsServiceAccountsTrustedPublishersResponseItemCapabilitie value)
        {
            return value switch
            {
                GetOrganizationsServiceAccountsTrustedPublishersResponseItemCapabilitie.InferenceApi => "inference-api",
                GetOrganizationsServiceAccountsTrustedPublishersResponseItemCapabilitie.RequestGatedRepos => "request-gated-repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsServiceAccountsTrustedPublishersResponseItemCapabilitie? ToEnum(string value)
        {
            return value switch
            {
                "inference-api" => GetOrganizationsServiceAccountsTrustedPublishersResponseItemCapabilitie.InferenceApi,
                "request-gated-repos" => GetOrganizationsServiceAccountsTrustedPublishersResponseItemCapabilitie.RequestGatedRepos,
                _ => null,
            };
        }
    }
}