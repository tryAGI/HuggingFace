
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOwnerVariant2PrimaryOrgPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Team,
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
        Academia,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOwnerVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOwnerVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseOwnerVariant2PrimaryOrgPlan.Team => "team",
                ResponseOwnerVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseOwnerVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseOwnerVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOwnerVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseOwnerVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseOwnerVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseOwnerVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseOwnerVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}