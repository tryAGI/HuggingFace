
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnum
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
    public static class PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnum value)
        {
            return value switch
            {
                PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnum.Bucket => "bucket",
                PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnum.Dataset => "dataset",
                PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnum.Kernel => "kernel",
                PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnum.Model => "model",
                PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnum.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnum? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnum.Bucket,
                "dataset" => PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnum.Dataset,
                "kernel" => PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnum.Kernel,
                "model" => PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnum.Model,
                "space" => PatchOrganizationsSettingsNetworkSecurityRequestBlockedContentResourceEnum.Space,
                _ => null,
            };
        }
    }
}