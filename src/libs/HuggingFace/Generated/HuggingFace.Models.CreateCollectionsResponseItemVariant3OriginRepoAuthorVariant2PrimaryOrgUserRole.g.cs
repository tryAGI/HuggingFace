
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole
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
    public static class CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Read => "read",
                CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.NoAccess,
                "read" => CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => CreateCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}