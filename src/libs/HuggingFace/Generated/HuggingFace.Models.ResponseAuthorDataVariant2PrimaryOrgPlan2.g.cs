
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseAuthorDataVariant2PrimaryOrgPlan2
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
    public static class ResponseAuthorDataVariant2PrimaryOrgPlan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAuthorDataVariant2PrimaryOrgPlan2 value)
        {
            return value switch
            {
                ResponseAuthorDataVariant2PrimaryOrgPlan2.Team => "team",
                ResponseAuthorDataVariant2PrimaryOrgPlan2.Enterprise => "enterprise",
                ResponseAuthorDataVariant2PrimaryOrgPlan2.Plus => "plus",
                ResponseAuthorDataVariant2PrimaryOrgPlan2.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAuthorDataVariant2PrimaryOrgPlan2? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseAuthorDataVariant2PrimaryOrgPlan2.Team,
                "enterprise" => ResponseAuthorDataVariant2PrimaryOrgPlan2.Enterprise,
                "plus" => ResponseAuthorDataVariant2PrimaryOrgPlan2.Plus,
                "academia" => ResponseAuthorDataVariant2PrimaryOrgPlan2.Academia,
                _ => null,
            };
        }
    }
}