
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole
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
    public static class ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Write => "write",
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseItemVariant3OriginRepoAuthorVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}