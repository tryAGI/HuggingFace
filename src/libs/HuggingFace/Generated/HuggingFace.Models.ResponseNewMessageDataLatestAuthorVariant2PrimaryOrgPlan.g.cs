
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan
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
    public static class ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Team => "team",
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}