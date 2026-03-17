
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewTitleAuthorVariant2PrimaryOrgPlan
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
    public static class ResponseNewTitleAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewTitleAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseNewTitleAuthorVariant2PrimaryOrgPlan.Team => "team",
                ResponseNewTitleAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseNewTitleAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseNewTitleAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewTitleAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewTitleAuthorVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseNewTitleAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseNewTitleAuthorVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseNewTitleAuthorVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}