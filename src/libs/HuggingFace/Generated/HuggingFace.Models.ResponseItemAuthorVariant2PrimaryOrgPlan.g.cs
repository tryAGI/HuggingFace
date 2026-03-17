
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemAuthorVariant2PrimaryOrgPlan
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
    public static class ResponseItemAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseItemAuthorVariant2PrimaryOrgPlan.Team => "team",
                ResponseItemAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseItemAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseItemAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemAuthorVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseItemAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseItemAuthorVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseItemAuthorVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}