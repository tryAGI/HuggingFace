
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource
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
    public static class GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource value)
        {
            return value switch
            {
                GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Bucket => "bucket",
                GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Dataset => "dataset",
                GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Kernel => "kernel",
                GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Model => "model",
                GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Bucket,
                "dataset" => GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Dataset,
                "kernel" => GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Kernel,
                "model" => GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Model,
                "space" => GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Space,
                _ => null,
            };
        }
    }
}