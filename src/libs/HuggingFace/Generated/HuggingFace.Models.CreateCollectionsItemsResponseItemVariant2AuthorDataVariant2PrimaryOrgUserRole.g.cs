
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole
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
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Admin => "admin",
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Read => "read",
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Contributor,
                "read" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Read,
                "write" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}