
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseOwnerVariant1Plan
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
    public static class GetCollectionsResponseOwnerVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseOwnerVariant1Plan value)
        {
            return value switch
            {
                GetCollectionsResponseOwnerVariant1Plan.Academia => "academia",
                GetCollectionsResponseOwnerVariant1Plan.Enterprise => "enterprise",
                GetCollectionsResponseOwnerVariant1Plan.Plus => "plus",
                GetCollectionsResponseOwnerVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseOwnerVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetCollectionsResponseOwnerVariant1Plan.Academia,
                "enterprise" => GetCollectionsResponseOwnerVariant1Plan.Enterprise,
                "plus" => GetCollectionsResponseOwnerVariant1Plan.Plus,
                "team" => GetCollectionsResponseOwnerVariant1Plan.Team,
                _ => null,
            };
        }
    }
}