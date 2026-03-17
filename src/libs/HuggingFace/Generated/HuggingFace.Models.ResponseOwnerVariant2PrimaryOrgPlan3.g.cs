
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOwnerVariant2PrimaryOrgPlan3
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
    public static class ResponseOwnerVariant2PrimaryOrgPlan3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOwnerVariant2PrimaryOrgPlan3 value)
        {
            return value switch
            {
                ResponseOwnerVariant2PrimaryOrgPlan3.Team => "team",
                ResponseOwnerVariant2PrimaryOrgPlan3.Enterprise => "enterprise",
                ResponseOwnerVariant2PrimaryOrgPlan3.Plus => "plus",
                ResponseOwnerVariant2PrimaryOrgPlan3.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOwnerVariant2PrimaryOrgPlan3? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseOwnerVariant2PrimaryOrgPlan3.Team,
                "enterprise" => ResponseOwnerVariant2PrimaryOrgPlan3.Enterprise,
                "plus" => ResponseOwnerVariant2PrimaryOrgPlan3.Plus,
                "academia" => ResponseOwnerVariant2PrimaryOrgPlan3.Academia,
                _ => null,
            };
        }
    }
}