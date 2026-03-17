
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2
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
    public static class ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2 value)
        {
            return value switch
            {
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2.Team => "team",
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2.Enterprise => "enterprise",
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2.Plus => "plus",
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2.Team,
                "enterprise" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2.Enterprise,
                "plus" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2.Plus,
                "academia" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan2.Academia,
                _ => null,
            };
        }
    }
}