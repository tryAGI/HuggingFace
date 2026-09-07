
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource
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
    public static class PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource value)
        {
            return value switch
            {
                PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource.Bucket => "bucket",
                PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource.Dataset => "dataset",
                PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource.Kernel => "kernel",
                PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource.Model => "model",
                PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource.Bucket,
                "dataset" => PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource.Dataset,
                "kernel" => PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource.Kernel,
                "model" => PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource.Model,
                "space" => PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResource.Space,
                _ => null,
            };
        }
    }
}