
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDiscussionAuthorVariant2PrimaryOrgUserRole
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
    public static class ResponseDiscussionAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDiscussionAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseDiscussionAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseDiscussionAuthorVariant2PrimaryOrgUserRole.Write => "write",
                ResponseDiscussionAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseDiscussionAuthorVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDiscussionAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseDiscussionAuthorVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseDiscussionAuthorVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseDiscussionAuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseDiscussionAuthorVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}