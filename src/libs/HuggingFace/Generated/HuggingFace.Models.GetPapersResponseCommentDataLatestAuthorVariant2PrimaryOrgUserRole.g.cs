
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole
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
    public static class GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole.Read => "read",
                GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole.NoAccess,
                "read" => GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}