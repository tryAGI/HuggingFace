
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageAuthorVariant2PrimaryOrgPlan2
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
    public static class ResponseNewMessageAuthorVariant2PrimaryOrgPlan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageAuthorVariant2PrimaryOrgPlan2 value)
        {
            return value switch
            {
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Team => "team",
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Enterprise => "enterprise",
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Plus => "plus",
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageAuthorVariant2PrimaryOrgPlan2? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Team,
                "enterprise" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Enterprise,
                "plus" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Plus,
                "academia" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan2.Academia,
                _ => null,
            };
        }
    }
}