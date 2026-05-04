
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum
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
    public static class PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum value)
        {
            return value switch
            {
                PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Bucket => "bucket",
                PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Dataset => "dataset",
                PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Kernel => "kernel",
                PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Model => "model",
                PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Bucket,
                "dataset" => PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Dataset,
                "kernel" => PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Kernel,
                "model" => PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Model,
                "space" => PatchOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Space,
                _ => null,
            };
        }
    }
}