
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant5OwnerVariant1Plan5
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
    public static class ResponseItemVariant5OwnerVariant1Plan5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant5OwnerVariant1Plan5 value)
        {
            return value switch
            {
                ResponseItemVariant5OwnerVariant1Plan5.Team => "team",
                ResponseItemVariant5OwnerVariant1Plan5.Enterprise => "enterprise",
                ResponseItemVariant5OwnerVariant1Plan5.Plus => "plus",
                ResponseItemVariant5OwnerVariant1Plan5.Academia => "academia",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant5OwnerVariant1Plan5? ToEnum(string value)
        {
            return value switch
            {
                "team" => ResponseItemVariant5OwnerVariant1Plan5.Team,
                "enterprise" => ResponseItemVariant5OwnerVariant1Plan5.Enterprise,
                "plus" => ResponseItemVariant5OwnerVariant1Plan5.Plus,
                "academia" => ResponseItemVariant5OwnerVariant1Plan5.Academia,
                _ => null,
            };
        }
    }
}