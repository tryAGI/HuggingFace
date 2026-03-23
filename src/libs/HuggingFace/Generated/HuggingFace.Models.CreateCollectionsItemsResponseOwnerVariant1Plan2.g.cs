
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateCollectionsItemsResponseOwnerVariant1Plan2
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
    public static class CreateCollectionsItemsResponseOwnerVariant1Plan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCollectionsItemsResponseOwnerVariant1Plan2 value)
        {
            return value switch
            {
                CreateCollectionsItemsResponseOwnerVariant1Plan2.Academia => "academia",
                CreateCollectionsItemsResponseOwnerVariant1Plan2.Enterprise => "enterprise",
                CreateCollectionsItemsResponseOwnerVariant1Plan2.Plus => "plus",
                CreateCollectionsItemsResponseOwnerVariant1Plan2.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCollectionsItemsResponseOwnerVariant1Plan2? ToEnum(string value)
        {
            return value switch
            {
                "academia" => CreateCollectionsItemsResponseOwnerVariant1Plan2.Academia,
                "enterprise" => CreateCollectionsItemsResponseOwnerVariant1Plan2.Enterprise,
                "plus" => CreateCollectionsItemsResponseOwnerVariant1Plan2.Plus,
                "team" => CreateCollectionsItemsResponseOwnerVariant1Plan2.Team,
                _ => null,
            };
        }
    }
}