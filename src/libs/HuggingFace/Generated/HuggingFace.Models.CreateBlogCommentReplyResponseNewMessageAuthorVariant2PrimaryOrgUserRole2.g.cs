
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole2
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
    public static class CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole2.Admin => "admin",
                CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole2.Read => "read",
                CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole2.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole2.Admin,
                "contributor" => CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole2.Contributor,
                "read" => CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole2.Read,
                "write" => CreateBlogCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole2.Write,
                _ => null,
            };
        }
    }
}