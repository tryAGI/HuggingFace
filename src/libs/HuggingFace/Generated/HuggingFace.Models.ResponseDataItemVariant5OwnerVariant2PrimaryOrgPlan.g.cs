
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan
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
    public static class ResponseDataItemVariant5OwnerVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan.Team => "team",
                ResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseDataItemVariant5OwnerVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}