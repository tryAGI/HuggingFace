
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemPusherPrimaryOrgPlan
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
    public static class ResponseItemPusherPrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemPusherPrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseItemPusherPrimaryOrgPlan.Team => "team",
                ResponseItemPusherPrimaryOrgPlan.Enterprise => "enterprise",
                ResponseItemPusherPrimaryOrgPlan.Plus => "plus",
                ResponseItemPusherPrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemPusherPrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemPusherPrimaryOrgPlan.Team,
                "enterprise" => ResponseItemPusherPrimaryOrgPlan.Enterprise,
                "plus" => ResponseItemPusherPrimaryOrgPlan.Plus,
                "academia" => ResponseItemPusherPrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}