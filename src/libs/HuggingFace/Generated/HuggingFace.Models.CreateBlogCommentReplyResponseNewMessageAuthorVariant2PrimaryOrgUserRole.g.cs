
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole
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
    public static class CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Read => "read",
                CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}