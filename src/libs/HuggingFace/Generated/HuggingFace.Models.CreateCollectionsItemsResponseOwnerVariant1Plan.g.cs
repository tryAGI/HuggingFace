
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseOwnerVariant1Plan
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
    public static class CreateCollectionsItemsResponseOwnerVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseOwnerVariant1Plan value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseOwnerVariant1Plan.Academia => "academia",
                CreateCollectionsItemsResponseOwnerVariant1Plan.Enterprise => "enterprise",
                CreateCollectionsItemsResponseOwnerVariant1Plan.Plus => "plus",
                CreateCollectionsItemsResponseOwnerVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseOwnerVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateCollectionsItemsResponseOwnerVariant1Plan.Academia,
                "enterprise" => CreateCollectionsItemsResponseOwnerVariant1Plan.Enterprise,
                "plus" => CreateCollectionsItemsResponseOwnerVariant1Plan.Plus,
                "team" => CreateCollectionsItemsResponseOwnerVariant1Plan.Team,
                _ => null,
            };
        }
    }
}