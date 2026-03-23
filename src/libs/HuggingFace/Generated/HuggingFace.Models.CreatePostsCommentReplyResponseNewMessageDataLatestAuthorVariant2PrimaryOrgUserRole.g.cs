
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole
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
    public static class CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Read => "read",
                CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => CreatePostsCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}