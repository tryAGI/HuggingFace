
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseVariant1AuthorVariant2PrimaryOrgPlan
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
    public static class GetDiscussionsResponseVariant1AuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseVariant1AuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                GetDiscussionsResponseVariant1AuthorVariant2PrimaryOrgPlan.Academia => "academia",
                GetDiscussionsResponseVariant1AuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                GetDiscussionsResponseVariant1AuthorVariant2PrimaryOrgPlan.Plus => "plus",
                GetDiscussionsResponseVariant1AuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseVariant1AuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetDiscussionsResponseVariant1AuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => GetDiscussionsResponseVariant1AuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => GetDiscussionsResponseVariant1AuthorVariant2PrimaryOrgPlan.Plus,
                "team" => GetDiscussionsResponseVariant1AuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}