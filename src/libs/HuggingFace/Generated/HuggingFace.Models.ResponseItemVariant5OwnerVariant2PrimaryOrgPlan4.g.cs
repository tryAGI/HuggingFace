
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant5OwnerVariant2PrimaryOrgPlan4
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
    public static class ResponseItemVariant5OwnerVariant2PrimaryOrgPlan4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant5OwnerVariant2PrimaryOrgPlan4 value)
        {
            return value switch
            {
                ResponseItemVariant5OwnerVariant2PrimaryOrgPlan4.Team => "team",
                ResponseItemVariant5OwnerVariant2PrimaryOrgPlan4.Enterprise => "enterprise",
                ResponseItemVariant5OwnerVariant2PrimaryOrgPlan4.Plus => "plus",
                ResponseItemVariant5OwnerVariant2PrimaryOrgPlan4.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant5OwnerVariant2PrimaryOrgPlan4? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemVariant5OwnerVariant2PrimaryOrgPlan4.Team,
                "enterprise" => ResponseItemVariant5OwnerVariant2PrimaryOrgPlan4.Enterprise,
                "plus" => ResponseItemVariant5OwnerVariant2PrimaryOrgPlan4.Plus,
                "academia" => ResponseItemVariant5OwnerVariant2PrimaryOrgPlan4.Academia,
                _ => null,
            };
        }
    }
}