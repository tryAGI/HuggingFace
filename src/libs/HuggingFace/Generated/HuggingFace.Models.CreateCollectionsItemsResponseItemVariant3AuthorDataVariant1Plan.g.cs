
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseItemVariant3AuthorDataVariant1Plan
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
    public static class CreateCollectionsItemsResponseItemVariant3AuthorDataVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseItemVariant3AuthorDataVariant1Plan value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseItemVariant3AuthorDataVariant1Plan.Academia => "academia",
                CreateCollectionsItemsResponseItemVariant3AuthorDataVariant1Plan.Enterprise => "enterprise",
                CreateCollectionsItemsResponseItemVariant3AuthorDataVariant1Plan.Plus => "plus",
                CreateCollectionsItemsResponseItemVariant3AuthorDataVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseItemVariant3AuthorDataVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateCollectionsItemsResponseItemVariant3AuthorDataVariant1Plan.Academia,
                "enterprise" => CreateCollectionsItemsResponseItemVariant3AuthorDataVariant1Plan.Enterprise,
                "plus" => CreateCollectionsItemsResponseItemVariant3AuthorDataVariant1Plan.Plus,
                "team" => CreateCollectionsItemsResponseItemVariant3AuthorDataVariant1Plan.Team,
                _ => null,
            };
        }
    }
}