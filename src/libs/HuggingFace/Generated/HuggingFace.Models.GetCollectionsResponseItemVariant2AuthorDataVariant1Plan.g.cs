
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant2AuthorDataVariant1Plan
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
    public static class GetCollectionsResponseItemVariant2AuthorDataVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant2AuthorDataVariant1Plan value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant2AuthorDataVariant1Plan.Academia => "academia",
                GetCollectionsResponseItemVariant2AuthorDataVariant1Plan.Enterprise => "enterprise",
                GetCollectionsResponseItemVariant2AuthorDataVariant1Plan.Plus => "plus",
                GetCollectionsResponseItemVariant2AuthorDataVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant2AuthorDataVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetCollectionsResponseItemVariant2AuthorDataVariant1Plan.Academia,
                "enterprise" => GetCollectionsResponseItemVariant2AuthorDataVariant1Plan.Enterprise,
                "plus" => GetCollectionsResponseItemVariant2AuthorDataVariant1Plan.Plus,
                "team" => GetCollectionsResponseItemVariant2AuthorDataVariant1Plan.Team,
                _ => null,
            };
        }
    }
}