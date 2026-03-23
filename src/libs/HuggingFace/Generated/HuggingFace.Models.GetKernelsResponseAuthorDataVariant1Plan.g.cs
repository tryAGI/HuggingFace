
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKernelsResponseAuthorDataVariant1Plan
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
    public static class GetKernelsResponseAuthorDataVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsResponseAuthorDataVariant1Plan value)
        {
            return value switch
            {
                GetKernelsResponseAuthorDataVariant1Plan.Academia => "academia",
                GetKernelsResponseAuthorDataVariant1Plan.Enterprise => "enterprise",
                GetKernelsResponseAuthorDataVariant1Plan.Plus => "plus",
                GetKernelsResponseAuthorDataVariant1Plan.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsResponseAuthorDataVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "academia" => GetKernelsResponseAuthorDataVariant1Plan.Academia,
                "enterprise" => GetKernelsResponseAuthorDataVariant1Plan.Enterprise,
                "plus" => GetKernelsResponseAuthorDataVariant1Plan.Plus,
                "team" => GetKernelsResponseAuthorDataVariant1Plan.Team,
                _ => null,
            };
        }
    }
}