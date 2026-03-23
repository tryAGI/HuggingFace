
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Contributor,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole value)
        {
            return value switch
            {
                GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole.Admin => "admin",
                GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole.Contributor => "contributor",
                GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole.Read => "read",
                GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole.Admin,
                "contributor" => GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole.Contributor,
                "read" => GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole.Read,
                "write" => GetModelsLfsFilesResponseItemPusherPrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}