
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataOwnerVariant2PrimaryOrgPlan2
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
    public static class ResponseDataOwnerVariant2PrimaryOrgPlan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataOwnerVariant2PrimaryOrgPlan2 value)
        {
            return value switch
            {
                ResponseDataOwnerVariant2PrimaryOrgPlan2.Team => "team",
                ResponseDataOwnerVariant2PrimaryOrgPlan2.Enterprise => "enterprise",
                ResponseDataOwnerVariant2PrimaryOrgPlan2.Plus => "plus",
                ResponseDataOwnerVariant2PrimaryOrgPlan2.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataOwnerVariant2PrimaryOrgPlan2? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseDataOwnerVariant2PrimaryOrgPlan2.Team,
                "enterprise" => ResponseDataOwnerVariant2PrimaryOrgPlan2.Enterprise,
                "plus" => ResponseDataOwnerVariant2PrimaryOrgPlan2.Plus,
                "academia" => ResponseDataOwnerVariant2PrimaryOrgPlan2.Academia,
                _ => null,
            };
        }
    }
}