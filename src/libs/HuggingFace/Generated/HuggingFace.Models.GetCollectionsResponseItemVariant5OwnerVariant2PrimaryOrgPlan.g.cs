
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan
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
    public static class GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Academia => "academia",
                GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Plus => "plus",
                GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Academia,
                "enterprise" => GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Enterprise,
                "plus" => GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Plus,
                "team" => GetCollectionsResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}