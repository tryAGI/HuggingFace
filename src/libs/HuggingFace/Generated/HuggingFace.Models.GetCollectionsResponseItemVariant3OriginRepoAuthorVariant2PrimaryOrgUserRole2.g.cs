
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2
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
    public static class GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Admin => "admin",
                GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Read => "read",
                GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Admin,
                "contributor" => GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Contributor,
                "read" => GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Read,
                "write" => GetCollectionsResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Write,
                _ => null,
            };
        }
    }
}