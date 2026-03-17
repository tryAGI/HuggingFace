
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOwnerVariant2PrimaryOrgPlan4
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
    public static class ResponseOwnerVariant2PrimaryOrgPlan4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOwnerVariant2PrimaryOrgPlan4 value)
        {
            return value switch
            {
                ResponseOwnerVariant2PrimaryOrgPlan4.Team => "team",
                ResponseOwnerVariant2PrimaryOrgPlan4.Enterprise => "enterprise",
                ResponseOwnerVariant2PrimaryOrgPlan4.Plus => "plus",
                ResponseOwnerVariant2PrimaryOrgPlan4.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOwnerVariant2PrimaryOrgPlan4? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseOwnerVariant2PrimaryOrgPlan4.Team,
                "enterprise" => ResponseOwnerVariant2PrimaryOrgPlan4.Enterprise,
                "plus" => ResponseOwnerVariant2PrimaryOrgPlan4.Plus,
                "academia" => ResponseOwnerVariant2PrimaryOrgPlan4.Academia,
                _ => null,
            };
        }
    }
}