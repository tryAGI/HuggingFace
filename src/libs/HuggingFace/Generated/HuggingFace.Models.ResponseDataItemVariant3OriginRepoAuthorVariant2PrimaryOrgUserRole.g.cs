
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole
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
    public static class ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Write => "write",
                ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseDataItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}