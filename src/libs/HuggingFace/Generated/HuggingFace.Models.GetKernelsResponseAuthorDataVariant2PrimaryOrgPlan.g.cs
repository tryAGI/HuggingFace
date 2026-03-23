
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan
    {
        /// <summary>
        /// 
        /// </summary>
        Academia,
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
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetKernelsResponseAuthorDataVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan.Academia => "academia",
                GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan.Plus => "plus",
                GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan.Academia,
                "enterprise" => GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan.Enterprise,
                "plus" => GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan.Plus,
                "team" => GetKernelsResponseAuthorDataVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}