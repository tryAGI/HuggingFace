
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole2
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
    public static class CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole2.Admin => "admin",
                CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole2.Read => "read",
                CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole2.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole2.Admin,
                "contributor" => CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole2.Contributor,
                "read" => CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole2.Read,
                "write" => CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole2.Write,
                _ => null,
            };
        }
    }
}