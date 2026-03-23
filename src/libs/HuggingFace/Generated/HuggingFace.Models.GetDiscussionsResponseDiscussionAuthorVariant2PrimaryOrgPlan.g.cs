
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgPlan
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
    public static class GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => GetDiscussionsResponseDiscussionAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}