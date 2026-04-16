
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole
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
    public static class CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Read => "read",
                CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.NoAccess,
                "read" => CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}