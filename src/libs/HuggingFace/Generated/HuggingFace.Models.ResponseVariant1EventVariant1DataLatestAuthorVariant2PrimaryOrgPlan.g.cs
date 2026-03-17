
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan
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
    public static class ResponseVariant1EventVariant1DataLatestAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseVariant1EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan.Team => "team",
                ResponseVariant1EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseVariant1EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseVariant1EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseVariant1EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseVariant1EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseVariant1EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseVariant1EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}