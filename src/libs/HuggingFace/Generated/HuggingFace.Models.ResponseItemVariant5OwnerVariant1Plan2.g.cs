
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant5OwnerVariant1Plan2
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
    public static class ResponseItemVariant5OwnerVariant1Plan2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant5OwnerVariant1Plan2 value)
        {
            return value switch
            {
                ResponseItemVariant5OwnerVariant1Plan2.Team => "team",
                ResponseItemVariant5OwnerVariant1Plan2.Enterprise => "enterprise",
                ResponseItemVariant5OwnerVariant1Plan2.Plus => "plus",
                ResponseItemVariant5OwnerVariant1Plan2.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant5OwnerVariant1Plan2? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemVariant5OwnerVariant1Plan2.Team,
                "enterprise" => ResponseItemVariant5OwnerVariant1Plan2.Enterprise,
                "plus" => ResponseItemVariant5OwnerVariant1Plan2.Plus,
                "academia" => ResponseItemVariant5OwnerVariant1Plan2.Academia,
                _ => null,
            };
        }
    }
}