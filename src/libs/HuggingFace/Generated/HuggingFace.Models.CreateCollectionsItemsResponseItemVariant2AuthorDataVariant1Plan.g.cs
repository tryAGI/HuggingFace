
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant2AuthorDataVariant1Plan
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
    public static class CreateCollectionsItemsResponseItemVariant2AuthorDataVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant2AuthorDataVariant1Plan value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant1Plan.Academia => "academia",
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant1Plan.Enterprise => "enterprise",
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant1Plan.Plus => "plus",
                CreateCollectionsItemsResponseItemVariant2AuthorDataVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant2AuthorDataVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant1Plan.Academia,
                "enterprise" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant1Plan.Enterprise,
                "plus" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant1Plan.Plus,
                "team" => CreateCollectionsItemsResponseItemVariant2AuthorDataVariant1Plan.Team,
                _ => null,
            };
        }
    }
}