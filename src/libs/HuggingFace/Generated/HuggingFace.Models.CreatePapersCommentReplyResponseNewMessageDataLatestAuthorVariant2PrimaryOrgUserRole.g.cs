
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole
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
    public static class CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Read => "read",
                CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => CreatePapersCommentReplyResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}