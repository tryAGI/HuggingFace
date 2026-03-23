
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole
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
    public static class CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Read => "read",
                CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => CreatePapersCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}