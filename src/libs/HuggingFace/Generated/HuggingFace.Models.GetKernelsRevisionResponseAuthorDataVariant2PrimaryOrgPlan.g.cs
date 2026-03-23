
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan
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
    public static class GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan value)
        {
            return value switch
            {
                GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan.Academia => "academia",
                GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan.Enterprise => "enterprise",
                GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan.Plus => "plus",
                GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan.Academia,
                "enterprise" => GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan.Enterprise,
                "plus" => GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan.Plus,
                "team" => GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgPlan.Team,
                _ => null,
            };
        }
    }
}