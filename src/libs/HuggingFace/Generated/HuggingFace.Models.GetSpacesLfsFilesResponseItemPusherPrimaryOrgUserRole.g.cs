
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole
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
    public static class GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole value)
        {
            return value switch
            {
                GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole.Admin => "admin",
                GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole.Contributor => "contributor",
                GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole.Read => "read",
                GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole.Admin,
                "contributor" => GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole.Contributor,
                "read" => GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole.Read,
                "write" => GetSpacesLfsFilesResponseItemPusherPrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}