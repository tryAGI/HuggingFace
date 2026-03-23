
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKernelsRevisionResponseAuthorDataVariant1Plan
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
    public static class GetKernelsRevisionResponseAuthorDataVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsRevisionResponseAuthorDataVariant1Plan value)
        {
            return value switch
            {
                GetKernelsRevisionResponseAuthorDataVariant1Plan.Academia => "academia",
                GetKernelsRevisionResponseAuthorDataVariant1Plan.Enterprise => "enterprise",
                GetKernelsRevisionResponseAuthorDataVariant1Plan.Plus => "plus",
                GetKernelsRevisionResponseAuthorDataVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsRevisionResponseAuthorDataVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetKernelsRevisionResponseAuthorDataVariant1Plan.Academia,
                "enterprise" => GetKernelsRevisionResponseAuthorDataVariant1Plan.Enterprise,
                "plus" => GetKernelsRevisionResponseAuthorDataVariant1Plan.Plus,
                "team" => GetKernelsRevisionResponseAuthorDataVariant1Plan.Team,
                _ => null,
            };
        }
    }
}