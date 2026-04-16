
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole
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
    public static class CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Read => "read",
                CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.NoAccess,
                "read" => CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => CreateBlogCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}