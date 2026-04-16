
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsLfsFilesResponseItemPusherPrimaryOrgUserRole
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
        NoAccess,
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
    public static class GetDatasetsLfsFilesResponseItemPusherPrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsLfsFilesResponseItemPusherPrimaryOrgUserRole value)
        {
            return value switch
            {
                GetDatasetsLfsFilesResponseItemPusherPrimaryOrgUserRole.Admin => "admin",
                GetDatasetsLfsFilesResponseItemPusherPrimaryOrgUserRole.Contributor => "contributor",
                GetDatasetsLfsFilesResponseItemPusherPrimaryOrgUserRole.NoAccess => "no_access",
                GetDatasetsLfsFilesResponseItemPusherPrimaryOrgUserRole.Read => "read",
                GetDatasetsLfsFilesResponseItemPusherPrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsLfsFilesResponseItemPusherPrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetDatasetsLfsFilesResponseItemPusherPrimaryOrgUserRole.Admin,
                "contributor" => GetDatasetsLfsFilesResponseItemPusherPrimaryOrgUserRole.Contributor,
                "no_access" => GetDatasetsLfsFilesResponseItemPusherPrimaryOrgUserRole.NoAccess,
                "read" => GetDatasetsLfsFilesResponseItemPusherPrimaryOrgUserRole.Read,
                "write" => GetDatasetsLfsFilesResponseItemPusherPrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}