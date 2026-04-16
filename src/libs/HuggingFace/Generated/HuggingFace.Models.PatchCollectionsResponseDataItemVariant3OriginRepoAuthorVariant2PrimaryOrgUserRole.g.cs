
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole
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
    public static class PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Read => "read",
                PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.NoAccess,
                "read" => PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => PatchCollectionsResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}