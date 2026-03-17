
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageAuthorVariant2PrimaryOrgPlan3
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
    public static class ResponseNewMessageAuthorVariant2PrimaryOrgPlan3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageAuthorVariant2PrimaryOrgPlan3 value)
        {
            return value switch
            {
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan3.Team => "team",
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan3.Enterprise => "enterprise",
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan3.Plus => "plus",
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan3.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageAuthorVariant2PrimaryOrgPlan3? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan3.Team,
                "enterprise" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan3.Enterprise,
                "plus" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan3.Plus,
                "academia" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan3.Academia,
                _ => null,
            };
        }
    }
}