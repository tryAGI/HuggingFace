
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum
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
    public static class GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum value)
        {
            return value switch
            {
                GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Bucket => "bucket",
                GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Dataset => "dataset",
                GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Kernel => "kernel",
                GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Model => "model",
                GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Bucket,
                "dataset" => GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Dataset,
                "kernel" => GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Kernel,
                "model" => GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Model,
                "space" => GetOrganizationsSettingsNetworkSecurityResponseAllowedContentResourceEnum.Space,
                _ => null,
            };
        }
    }
}