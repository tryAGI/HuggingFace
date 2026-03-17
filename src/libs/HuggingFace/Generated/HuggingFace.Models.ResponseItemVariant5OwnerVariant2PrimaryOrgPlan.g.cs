
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant5OwnerVariant2PrimaryOrgPlan
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
    public static class ResponseItemVariant5OwnerVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant5OwnerVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Team => "team",
                ResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant5OwnerVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseItemVariant5OwnerVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}