
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant2OrgPlan
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
    public static class ResponseVariant2OrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant2OrgPlan value)
        {
            return value switch
            {
                ResponseVariant2OrgPlan.Team => "team",
                ResponseVariant2OrgPlan.Enterprise => "enterprise",
                ResponseVariant2OrgPlan.Plus => "plus",
                ResponseVariant2OrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant2OrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseVariant2OrgPlan.Team,
                "enterprise" => ResponseVariant2OrgPlan.Enterprise,
                "plus" => ResponseVariant2OrgPlan.Plus,
                "academia" => ResponseVariant2OrgPlan.Academia,
                _ => null,
            };
        }
    }
}