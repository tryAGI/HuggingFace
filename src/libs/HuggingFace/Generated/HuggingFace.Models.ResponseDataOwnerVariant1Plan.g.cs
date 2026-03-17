
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataOwnerVariant1Plan
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
    public static class ResponseDataOwnerVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataOwnerVariant1Plan value)
        {
            return value switch
            {
                ResponseDataOwnerVariant1Plan.Team => "team",
                ResponseDataOwnerVariant1Plan.Enterprise => "enterprise",
                ResponseDataOwnerVariant1Plan.Plus => "plus",
                ResponseDataOwnerVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataOwnerVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseDataOwnerVariant1Plan.Team,
                "enterprise" => ResponseDataOwnerVariant1Plan.Enterprise,
                "plus" => ResponseDataOwnerVariant1Plan.Plus,
                "academia" => ResponseDataOwnerVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}