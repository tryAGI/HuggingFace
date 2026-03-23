
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Academia,
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
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}