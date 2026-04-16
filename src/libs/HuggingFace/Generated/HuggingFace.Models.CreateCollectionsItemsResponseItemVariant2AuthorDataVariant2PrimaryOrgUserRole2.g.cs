
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2
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
    public static class CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Admin => "admin",
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.NoAccess => "no_access",
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Read => "read",
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Admin,
                "contributor" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Contributor,
                "no_access" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.NoAccess,
                "read" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Read,
                "write" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Write,
                _ => null,
            };
        }
    }
}