
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole
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
    public static class CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Read => "read",
                CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.NoAccess,
                "read" => CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => CreatePapersCommentReplyResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}