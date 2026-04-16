
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole
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
    public static class CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Read => "read",
                CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.NoAccess,
                "read" => CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => CreatePostsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}