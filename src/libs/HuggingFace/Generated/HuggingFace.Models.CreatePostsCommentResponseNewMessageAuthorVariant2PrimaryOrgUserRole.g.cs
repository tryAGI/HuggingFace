
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole
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
    public static class CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Read => "read",
                CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => CreatePostsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}