
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource
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
    public static class PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource value)
        {
            return value switch
            {
                PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource.Bucket => "bucket",
                PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource.Dataset => "dataset",
                PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource.Kernel => "kernel",
                PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource.Model => "model",
                PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource.Bucket,
                "dataset" => PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource.Dataset,
                "kernel" => PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource.Kernel,
                "model" => PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource.Model,
                "space" => PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResource.Space,
                _ => null,
            };
        }
    }
}