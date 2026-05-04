
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResourceEnum
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
    public static class PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResourceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResourceEnum value)
        {
            return value switch
            {
                PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResourceEnum.Bucket => "bucket",
                PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResourceEnum.Dataset => "dataset",
                PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResourceEnum.Kernel => "kernel",
                PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResourceEnum.Model => "model",
                PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResourceEnum.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResourceEnum? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResourceEnum.Bucket,
                "dataset" => PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResourceEnum.Dataset,
                "kernel" => PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResourceEnum.Kernel,
                "model" => PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResourceEnum.Model,
                "space" => PatchOrganizationsSettingsNetworkSecurityRequestAllowedContentResourceEnum.Space,
                _ => null,
            };
        }
    }
}