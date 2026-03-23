
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan
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
    public static class PatchCollectionsResponseDataItemVariant2AuthorDataVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan value)
        {
            return value switch
            {
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan.Academia => "academia",
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan.Enterprise => "enterprise",
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan.Plus => "plus",
                PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan.Academia,
                "enterprise" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan.Enterprise,
                "plus" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan.Plus,
                "team" => PatchCollectionsResponseDataItemVariant2AuthorDataVariant1Plan.Team,
                _ => null,
            };
        }
    }
}