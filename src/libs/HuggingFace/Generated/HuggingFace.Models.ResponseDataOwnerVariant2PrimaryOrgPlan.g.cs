
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataOwnerVariant2PrimaryOrgPlan
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
    public static class ResponseDataOwnerVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataOwnerVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseDataOwnerVariant2PrimaryOrgPlan.Team => "team",
                ResponseDataOwnerVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseDataOwnerVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseDataOwnerVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataOwnerVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseDataOwnerVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseDataOwnerVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseDataOwnerVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseDataOwnerVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}