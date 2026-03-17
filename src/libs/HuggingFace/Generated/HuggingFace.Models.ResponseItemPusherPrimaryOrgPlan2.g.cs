
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemPusherPrimaryOrgPlan2
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
    public static class ResponseItemPusherPrimaryOrgPlan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemPusherPrimaryOrgPlan2 value)
        {
            return value switch
            {
                ResponseItemPusherPrimaryOrgPlan2.Team => "team",
                ResponseItemPusherPrimaryOrgPlan2.Enterprise => "enterprise",
                ResponseItemPusherPrimaryOrgPlan2.Plus => "plus",
                ResponseItemPusherPrimaryOrgPlan2.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemPusherPrimaryOrgPlan2? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemPusherPrimaryOrgPlan2.Team,
                "enterprise" => ResponseItemPusherPrimaryOrgPlan2.Enterprise,
                "plus" => ResponseItemPusherPrimaryOrgPlan2.Plus,
                "academia" => ResponseItemPusherPrimaryOrgPlan2.Academia,
                _ => null,
            };
        }
    }
}