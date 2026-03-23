
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseVariant1ItemOwnerVariant1Plan
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
    public static class GetCollectionsResponseVariant1ItemOwnerVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseVariant1ItemOwnerVariant1Plan value)
        {
            return value switch
            {
                GetCollectionsResponseVariant1ItemOwnerVariant1Plan.Academia => "academia",
                GetCollectionsResponseVariant1ItemOwnerVariant1Plan.Enterprise => "enterprise",
                GetCollectionsResponseVariant1ItemOwnerVariant1Plan.Plus => "plus",
                GetCollectionsResponseVariant1ItemOwnerVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseVariant1ItemOwnerVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetCollectionsResponseVariant1ItemOwnerVariant1Plan.Academia,
                "enterprise" => GetCollectionsResponseVariant1ItemOwnerVariant1Plan.Enterprise,
                "plus" => GetCollectionsResponseVariant1ItemOwnerVariant1Plan.Plus,
                "team" => GetCollectionsResponseVariant1ItemOwnerVariant1Plan.Team,
                _ => null,
            };
        }
    }
}