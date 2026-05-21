
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan
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
    public static class GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => GetPapersResponseCommentDataLatestAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}