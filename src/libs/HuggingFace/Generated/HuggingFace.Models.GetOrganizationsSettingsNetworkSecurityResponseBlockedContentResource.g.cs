
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource
    {
        /// <summary>
        ///
        /// </summary>
        Bucket,
        /// <summary>
        ///
        /// </summary>
        Dataset,
        /// <summary>
        ///
        /// </summary>
        Kernel,
        /// <summary>
        ///
        /// </summary>
        Model,
        /// <summary>
        ///
        /// </summary>
        Space,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource value)
        {
            return value switch
            {
                GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Bucket => "bucket",
                GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Dataset => "dataset",
                GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Kernel => "kernel",
                GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Model => "model",
                GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Bucket,
                "dataset" => GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Dataset,
                "kernel" => GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Kernel,
                "model" => GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Model,
                "space" => GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Space,
                _ => null,
            };
        }
    }
}