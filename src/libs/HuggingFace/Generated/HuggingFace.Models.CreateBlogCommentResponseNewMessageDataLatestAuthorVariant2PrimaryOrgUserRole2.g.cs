
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2
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
    public static class CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2.Admin => "admin",
                CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2.Read => "read",
                CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2.Admin,
                "contributor" => CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2.Contributor,
                "read" => CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2.Read,
                "write" => CreateBlogCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole2.Write,
                _ => null,
            };
        }
    }
}