
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2
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
    public static class CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2.Admin => "admin",
                CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2.NoAccess => "no_access",
                CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2.Read => "read",
                CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2.Admin,
                "contributor" => CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2.Contributor,
                "no_access" => CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2.NoAccess,
                "read" => CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2.Read,
                "write" => CreateBlogCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2.Write,
                _ => null,
            };
        }
    }
}