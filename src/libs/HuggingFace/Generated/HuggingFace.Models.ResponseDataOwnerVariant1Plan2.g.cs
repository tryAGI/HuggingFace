
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataOwnerVariant1Plan2
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
    public static class ResponseDataOwnerVariant1Plan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataOwnerVariant1Plan2 value)
        {
            return value switch
            {
                ResponseDataOwnerVariant1Plan2.Team => "team",
                ResponseDataOwnerVariant1Plan2.Enterprise => "enterprise",
                ResponseDataOwnerVariant1Plan2.Plus => "plus",
                ResponseDataOwnerVariant1Plan2.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataOwnerVariant1Plan2? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseDataOwnerVariant1Plan2.Team,
                "enterprise" => ResponseDataOwnerVariant1Plan2.Enterprise,
                "plus" => ResponseDataOwnerVariant1Plan2.Plus,
                "academia" => ResponseDataOwnerVariant1Plan2.Academia,
                _ => null,
            };
        }
    }
}