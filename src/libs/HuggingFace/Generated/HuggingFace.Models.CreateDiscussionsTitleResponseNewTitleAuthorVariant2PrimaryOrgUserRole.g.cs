
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgUserRole
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
    public static class CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgUserRole.Read => "read",
                CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgUserRole.NoAccess,
                "read" => CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => CreateDiscussionsTitleResponseNewTitleAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}