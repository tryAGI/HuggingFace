
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2
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
    public static class CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Admin => "admin",
                CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.NoAccess => "no_access",
                CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Read => "read",
                CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Admin,
                "contributor" => CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Contributor,
                "no_access" => CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.NoAccess,
                "read" => CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Read,
                "write" => CreateCollectionsItemsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Write,
                _ => null,
            };
        }
    }
}