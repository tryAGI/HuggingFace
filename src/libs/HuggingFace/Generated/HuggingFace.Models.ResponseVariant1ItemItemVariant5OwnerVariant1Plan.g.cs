
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemItemVariant5OwnerVariant1Plan
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
    public static class ResponseVariant1ItemItemVariant5OwnerVariant1PlanExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemItemVariant5OwnerVariant1Plan value)
        {
            return value switch
            {
                ResponseVariant1ItemItemVariant5OwnerVariant1Plan.Team => "team",
                ResponseVariant1ItemItemVariant5OwnerVariant1Plan.Enterprise => "enterprise",
                ResponseVariant1ItemItemVariant5OwnerVariant1Plan.Plus => "plus",
                ResponseVariant1ItemItemVariant5OwnerVariant1Plan.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemItemVariant5OwnerVariant1Plan? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseVariant1ItemItemVariant5OwnerVariant1Plan.Team,
                "enterprise" => ResponseVariant1ItemItemVariant5OwnerVariant1Plan.Enterprise,
                "plus" => ResponseVariant1ItemItemVariant5OwnerVariant1Plan.Plus,
                "academia" => ResponseVariant1ItemItemVariant5OwnerVariant1Plan.Academia,
                _ => null,
            };
        }
    }
}