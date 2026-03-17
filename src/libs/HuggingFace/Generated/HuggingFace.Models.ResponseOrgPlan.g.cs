
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOrgPlan
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
    public static class ResponseOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOrgPlan value)
        {
            return value switch
            {
                ResponseOrgPlan.Team => "team",
                ResponseOrgPlan.Enterprise => "enterprise",
                ResponseOrgPlan.Plus => "plus",
                ResponseOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseOrgPlan.Team,
                "enterprise" => ResponseOrgPlan.Enterprise,
                "plus" => ResponseOrgPlan.Plus,
                "academia" => ResponseOrgPlan.Academia,
                _ => null,
            };
        }
    }
}