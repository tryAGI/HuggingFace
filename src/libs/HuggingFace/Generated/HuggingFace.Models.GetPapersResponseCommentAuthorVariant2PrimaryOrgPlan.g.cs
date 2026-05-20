
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan
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
    public static class GetPapersResponseCommentAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan.Academia,
                "enterprise" => GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan.Plus,
                "team" => GetPapersResponseCommentAuthorVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}