
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole
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
    public static class CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole.Admin => "admin",
                CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole.Read => "read",
                CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole.NoAccess,
                "read" => CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole.Read,
                "write" => CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}