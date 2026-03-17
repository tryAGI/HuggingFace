
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageAuthorVariant2PrimaryOrgPlan4
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
    public static class ResponseNewMessageAuthorVariant2PrimaryOrgPlan4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageAuthorVariant2PrimaryOrgPlan4 value)
        {
            return value switch
            {
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan4.Team => "team",
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan4.Enterprise => "enterprise",
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan4.Plus => "plus",
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan4.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageAuthorVariant2PrimaryOrgPlan4? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan4.Team,
                "enterprise" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan4.Enterprise,
                "plus" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan4.Plus,
                "academia" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan4.Academia,
                _ => null,
            };
        }
    }
}