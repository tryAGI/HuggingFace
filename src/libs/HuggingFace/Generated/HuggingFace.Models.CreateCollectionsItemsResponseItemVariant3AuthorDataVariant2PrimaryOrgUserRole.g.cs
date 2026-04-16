
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole
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
    public static class CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Admin => "admin",
                CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Read => "read",
                CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.NoAccess,
                "read" => CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Read,
                "write" => CreateCollectionsItemsResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}