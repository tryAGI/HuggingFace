
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum
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
    public static class PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum value)
        {
            return value switch
            {
                PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Bucket => "bucket",
                PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Dataset => "dataset",
                PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Kernel => "kernel",
                PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Model => "model",
                PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Bucket,
                "dataset" => PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Dataset,
                "kernel" => PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Kernel,
                "model" => PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Model,
                "space" => PatchOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Space,
                _ => null,
            };
        }
    }
}