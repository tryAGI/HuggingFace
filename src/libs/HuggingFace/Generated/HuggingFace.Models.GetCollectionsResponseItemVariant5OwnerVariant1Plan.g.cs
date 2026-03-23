
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant5OwnerVariant1Plan
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
    public static class GetCollectionsResponseItemVariant5OwnerVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant5OwnerVariant1Plan value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant5OwnerVariant1Plan.Academia => "academia",
                GetCollectionsResponseItemVariant5OwnerVariant1Plan.Enterprise => "enterprise",
                GetCollectionsResponseItemVariant5OwnerVariant1Plan.Plus => "plus",
                GetCollectionsResponseItemVariant5OwnerVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant5OwnerVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetCollectionsResponseItemVariant5OwnerVariant1Plan.Academia,
                "enterprise" => GetCollectionsResponseItemVariant5OwnerVariant1Plan.Enterprise,
                "plus" => GetCollectionsResponseItemVariant5OwnerVariant1Plan.Plus,
                "team" => GetCollectionsResponseItemVariant5OwnerVariant1Plan.Team,
                _ => null,
            };
        }
    }
}