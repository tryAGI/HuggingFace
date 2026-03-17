
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageAuthorVariant2PrimaryOrgPlan8
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
    public static class ResponseNewMessageAuthorVariant2PrimaryOrgPlan8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageAuthorVariant2PrimaryOrgPlan8 value)
        {
            return value switch
            {
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan8.Team => "team",
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan8.Enterprise => "enterprise",
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan8.Plus => "plus",
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan8.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageAuthorVariant2PrimaryOrgPlan8? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan8.Team,
                "enterprise" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan8.Enterprise,
                "plus" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan8.Plus,
                "academia" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan8.Academia,
                _ => null,
            };
        }
    }
}