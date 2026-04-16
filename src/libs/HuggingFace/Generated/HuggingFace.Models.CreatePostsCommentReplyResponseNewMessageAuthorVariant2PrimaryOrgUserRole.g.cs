
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole
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
    public static class CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Read => "read",
                CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.NoAccess,
                "read" => CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => CreatePostsCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}