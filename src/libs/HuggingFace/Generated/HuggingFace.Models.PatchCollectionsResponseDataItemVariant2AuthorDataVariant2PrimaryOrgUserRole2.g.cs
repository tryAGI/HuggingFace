
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole2
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
    public static class PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Admin => "admin",
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Read => "read",
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Admin,
                "contributor" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Contributor,
                "read" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Read,
                "write" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant2PrimaryOrgUserRole2.Write,
                _ => null,
            };
        }
    }
}