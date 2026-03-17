
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Write,
        /// <summary>
        /// 
        /// </summary>
        Contributor,
        /// <summary>
        /// 
        /// </summary>
        Read,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Admin => "admin",
                ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Write => "write",
                ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Admin,
                "write" => ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Write,
                "contributor" => ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Contributor,
                "read" => ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Read,
                _ => null,
            };
        }
    }
}