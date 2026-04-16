
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole2
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
    public static class CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole2.Admin => "admin",
                CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole2.NoAccess => "no_access",
                CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole2.Read => "read",
                CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole2.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole2.Admin,
                "contributor" => CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole2.Contributor,
                "no_access" => CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole2.NoAccess,
                "read" => CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole2.Read,
                "write" => CreateCollectionsItemsResponseOwnerVariant2PrimaryOrgUserRole2.Write,
                _ => null,
            };
        }
    }
}