
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2
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
    public static class ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Admin => "admin",
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Write => "write",
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Admin,
                "write" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Write,
                "contributor" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Contributor,
                "read" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole2.Read,
                _ => null,
            };
        }
    }
}