
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole
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
    public static class CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Read => "read",
                CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.NoAccess,
                "read" => CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => CreateDiscussionsCommentResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}