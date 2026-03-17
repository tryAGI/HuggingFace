
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageAuthorVariant2PrimaryOrgPlan
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
    public static class ResponseNewMessageAuthorVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageAuthorVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan.Team => "team",
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan.Plus => "plus",
                ResponseNewMessageAuthorVariant2PrimaryOrgPlan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageAuthorVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan.Team,
                "enterprise" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan.Enterprise,
                "plus" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan.Plus,
                "academia" => ResponseNewMessageAuthorVariant2PrimaryOrgPlan.Academia,
                _ => null,
            };
        }
    }
}