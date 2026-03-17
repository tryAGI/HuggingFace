
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDiscussionAuthorVariant2PrimaryOrgPlan
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
    public static class ResponseDiscussionAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDiscussionAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseDiscussionAuthorVariant2PrimaryOrgPlan.Team => "team",
                ResponseDiscussionAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseDiscussionAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseDiscussionAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDiscussionAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseDiscussionAuthorVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseDiscussionAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseDiscussionAuthorVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseDiscussionAuthorVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}