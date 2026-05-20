
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole
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
    public static class GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole.Read => "read",
                GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole.NoAccess,
                "read" => GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => GetPapersResponseCommentAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}