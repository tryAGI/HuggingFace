
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole
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
    public static class CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Read => "read",
                CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.NoAccess,
                "read" => CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => CreateDiscussionsCommentResponseNewMessageAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}