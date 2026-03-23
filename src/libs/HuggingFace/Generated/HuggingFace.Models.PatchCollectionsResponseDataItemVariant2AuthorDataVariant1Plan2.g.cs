
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan2
    {
        /// <summary>
        /// 
        /// </summary>
        Academia,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        Plus,
        /// <summary>
        /// 
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan2 value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan2.Academia => "academia",
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan2.Enterprise => "enterprise",
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan2.Plus => "plus",
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan2.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan2? ToEnum(string value)
        {
            return value switch
            {
                "academia" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan2.Academia,
                "enterprise" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan2.Enterprise,
                "plus" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan2.Plus,
                "team" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan2.Team,
                _ => null,
            };
        }
    }
}