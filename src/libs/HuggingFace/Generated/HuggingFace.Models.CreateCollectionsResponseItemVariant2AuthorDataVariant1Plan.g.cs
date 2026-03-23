
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsResponseItemVariant2AuthorDataVariant1Plan
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
    public static class CreateCollectionsResponseItemVariant2AuthorDataVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsResponseItemVariant2AuthorDataVariant1Plan value)
        {
            return value switch
            {
                CreateCollectionsResponseItemVariant2AuthorDataVariant1Plan.Academia => "academia",
                CreateCollectionsResponseItemVariant2AuthorDataVariant1Plan.Enterprise => "enterprise",
                CreateCollectionsResponseItemVariant2AuthorDataVariant1Plan.Plus => "plus",
                CreateCollectionsResponseItemVariant2AuthorDataVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsResponseItemVariant2AuthorDataVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateCollectionsResponseItemVariant2AuthorDataVariant1Plan.Academia,
                "enterprise" => CreateCollectionsResponseItemVariant2AuthorDataVariant1Plan.Enterprise,
                "plus" => CreateCollectionsResponseItemVariant2AuthorDataVariant1Plan.Plus,
                "team" => CreateCollectionsResponseItemVariant2AuthorDataVariant1Plan.Team,
                _ => null,
            };
        }
    }
}