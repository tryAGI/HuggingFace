
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum
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
    public static class GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum value)
        {
            return value switch
            {
                GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Bucket => "bucket",
                GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Dataset => "dataset",
                GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Kernel => "kernel",
                GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Model => "model",
                GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Space => "space",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum? ToEnum(string value)
        {
            return value switch
            {
                "bucket" => GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Bucket,
                "dataset" => GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Dataset,
                "kernel" => GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Kernel,
                "model" => GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Model,
                "space" => GetOrganizationsSettingsNetworkSecurityResponseBlockedContentResourceEnum.Space,
                _ => null,
            };
        }
    }
}