
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole
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
    public static class CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Admin => "admin",
                CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Contributor => "contributor",
                CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Read => "read",
                CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Admin,
                "contributor" => CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Contributor,
                "read" => CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Read,
                "write" => CreateCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}