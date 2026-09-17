
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource
    {
        /// <summary>
        ///
        /// </summary>
        Bucket,
        /// <summary>
        ///
        /// </summary>
        Container,
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
    public static class PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource value)
        {
            return value switch
            {
                PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Bucket => "bucket",
                PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Container => "container",
                PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Dataset => "dataset",
                PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Kernel => "kernel",
                PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Model => "model",
                PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Bucket,
                "container" => PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Container,
                "dataset" => PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Dataset,
                "kernel" => PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Kernel,
                "model" => PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Model,
                "space" => PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResource.Space,
                _ => null,
            };
        }
    }
}