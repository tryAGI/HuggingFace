
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseAuthorDataVariant2PrimaryOrgPlan
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
    public static class ResponseAuthorDataVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAuthorDataVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseAuthorDataVariant2PrimaryOrgPlan.Team => "team",
                ResponseAuthorDataVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseAuthorDataVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseAuthorDataVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAuthorDataVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseAuthorDataVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseAuthorDataVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseAuthorDataVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseAuthorDataVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}