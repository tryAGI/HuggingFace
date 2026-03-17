
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemOwnerVariant1Plan
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
    public static class ResponseVariant1ItemOwnerVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemOwnerVariant1Plan value)
        {
            return value switch
            {
                ResponseVariant1ItemOwnerVariant1Plan.Team => "team",
                ResponseVariant1ItemOwnerVariant1Plan.Enterprise => "enterprise",
                ResponseVariant1ItemOwnerVariant1Plan.Plus => "plus",
                ResponseVariant1ItemOwnerVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemOwnerVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseVariant1ItemOwnerVariant1Plan.Team,
                "enterprise" => ResponseVariant1ItemOwnerVariant1Plan.Enterprise,
                "plus" => ResponseVariant1ItemOwnerVariant1Plan.Plus,
                "academia" => ResponseVariant1ItemOwnerVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}