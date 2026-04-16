
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole
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
    public static class CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Admin => "admin",
                CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Read => "read",
                CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.NoAccess,
                "read" => CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Read,
                "write" => CreateCollectionsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}