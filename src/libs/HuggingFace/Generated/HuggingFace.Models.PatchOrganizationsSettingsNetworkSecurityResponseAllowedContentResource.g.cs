
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource
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
    public static class PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource value)
        {
            return value switch
            {
                PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Bucket => "bucket",
                PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Dataset => "dataset",
                PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Kernel => "kernel",
                PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Model => "model",
                PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Bucket,
                "dataset" => PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Dataset,
                "kernel" => PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Kernel,
                "model" => PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Model,
                "space" => PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResource.Space,
                _ => null,
            };
        }
    }
}