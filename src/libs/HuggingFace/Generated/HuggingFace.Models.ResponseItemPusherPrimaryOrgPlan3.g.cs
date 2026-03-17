
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemPusherPrimaryOrgPlan3
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
    public static class ResponseItemPusherPrimaryOrgPlan3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemPusherPrimaryOrgPlan3 value)
        {
            return value switch
            {
                ResponseItemPusherPrimaryOrgPlan3.Team => "team",
                ResponseItemPusherPrimaryOrgPlan3.Enterprise => "enterprise",
                ResponseItemPusherPrimaryOrgPlan3.Plus => "plus",
                ResponseItemPusherPrimaryOrgPlan3.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemPusherPrimaryOrgPlan3? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemPusherPrimaryOrgPlan3.Team,
                "enterprise" => ResponseItemPusherPrimaryOrgPlan3.Enterprise,
                "plus" => ResponseItemPusherPrimaryOrgPlan3.Plus,
                "academia" => ResponseItemPusherPrimaryOrgPlan3.Academia,
                _ => null,
            };
        }
    }
}