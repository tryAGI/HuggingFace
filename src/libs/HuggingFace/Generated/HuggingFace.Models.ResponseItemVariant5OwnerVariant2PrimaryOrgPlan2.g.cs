
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant5OwnerVariant2PrimaryOrgPlan2
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
    public static class ResponseItemVariant5OwnerVariant2PrimaryOrgPlan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant5OwnerVariant2PrimaryOrgPlan2 value)
        {
            return value switch
            {
                ResponseItemVariant5OwnerVariant2PrimaryOrgPlan2.Team => "team",
                ResponseItemVariant5OwnerVariant2PrimaryOrgPlan2.Enterprise => "enterprise",
                ResponseItemVariant5OwnerVariant2PrimaryOrgPlan2.Plus => "plus",
                ResponseItemVariant5OwnerVariant2PrimaryOrgPlan2.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant5OwnerVariant2PrimaryOrgPlan2? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemVariant5OwnerVariant2PrimaryOrgPlan2.Team,
                "enterprise" => ResponseItemVariant5OwnerVariant2PrimaryOrgPlan2.Enterprise,
                "plus" => ResponseItemVariant5OwnerVariant2PrimaryOrgPlan2.Plus,
                "academia" => ResponseItemVariant5OwnerVariant2PrimaryOrgPlan2.Academia,
                _ => null,
            };
        }
    }
}