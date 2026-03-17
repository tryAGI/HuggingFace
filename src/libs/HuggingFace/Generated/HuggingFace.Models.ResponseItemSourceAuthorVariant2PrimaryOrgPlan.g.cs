
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSourceAuthorVariant2PrimaryOrgPlan
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
    public static class ResponseItemSourceAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSourceAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseItemSourceAuthorVariant2PrimaryOrgPlan.Team => "team",
                ResponseItemSourceAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseItemSourceAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseItemSourceAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSourceAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemSourceAuthorVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseItemSourceAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseItemSourceAuthorVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseItemSourceAuthorVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}