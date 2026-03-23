
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseOwnerVariant2PrimaryOrgPlan
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
    public static class GetCollectionsResponseOwnerVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseOwnerVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                GetCollectionsResponseOwnerVariant2PrimaryOrgPlan.Academia => "academia",
                GetCollectionsResponseOwnerVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                GetCollectionsResponseOwnerVariant2PrimaryOrgPlan.Plus => "plus",
                GetCollectionsResponseOwnerVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseOwnerVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetCollectionsResponseOwnerVariant2PrimaryOrgPlan.Academia,
                "enterprise" => GetCollectionsResponseOwnerVariant2PrimaryOrgPlan.Enterprise,
                "plus" => GetCollectionsResponseOwnerVariant2PrimaryOrgPlan.Plus,
                "team" => GetCollectionsResponseOwnerVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}