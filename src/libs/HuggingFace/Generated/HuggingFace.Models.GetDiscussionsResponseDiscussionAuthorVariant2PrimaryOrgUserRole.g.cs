
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgUserRole
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
    public static class GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgUserRole.Read => "read",
                GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}