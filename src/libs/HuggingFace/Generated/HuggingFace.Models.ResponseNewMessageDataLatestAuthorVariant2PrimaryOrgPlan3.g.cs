
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan3
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
    public static class ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan3 value)
        {
            return value switch
            {
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan3.Team => "team",
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan3.Enterprise => "enterprise",
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan3.Plus => "plus",
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan3.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan3? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan3.Team,
                "enterprise" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan3.Enterprise,
                "plus" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan3.Plus,
                "academia" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgPlan3.Academia,
                _ => null,
            };
        }
    }
}