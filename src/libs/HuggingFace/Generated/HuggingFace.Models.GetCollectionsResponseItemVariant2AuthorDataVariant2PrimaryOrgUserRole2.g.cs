
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2
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
    public static class GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Admin => "admin",
                GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Read => "read",
                GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Admin,
                "contributor" => GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Contributor,
                "read" => GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Read,
                "write" => GetCollectionsResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Write,
                _ => null,
            };
        }
    }
}