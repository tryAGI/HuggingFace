
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgUserRole
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
    public static class CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgUserRole.Read => "read",
                CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgUserRole.NoAccess,
                "read" => CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => CreateDiscussionsStatusResponseNewStatusAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}