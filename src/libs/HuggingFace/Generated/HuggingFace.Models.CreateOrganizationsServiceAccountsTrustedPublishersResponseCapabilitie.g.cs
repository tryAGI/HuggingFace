
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateOrganizationsServiceAccountsTrustedPublishersResponseCapabilitie
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
    public static class CreateOrganizationsServiceAccountsTrustedPublishersResponseCapabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsServiceAccountsTrustedPublishersResponseCapabilitie value)
        {
            return value switch
            {
                CreateOrganizationsServiceAccountsTrustedPublishersResponseCapabilitie.InferenceApi => "inference-api",
                CreateOrganizationsServiceAccountsTrustedPublishersResponseCapabilitie.RequestGatedRepos => "request-gated-repos",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsServiceAccountsTrustedPublishersResponseCapabilitie? ToEnum(string value)
        {
            return value switch
            {
                "inference-api" => CreateOrganizationsServiceAccountsTrustedPublishersResponseCapabilitie.InferenceApi,
                "request-gated-repos" => CreateOrganizationsServiceAccountsTrustedPublishersResponseCapabilitie.RequestGatedRepos,
                _ => null,
            };
        }
    }
}