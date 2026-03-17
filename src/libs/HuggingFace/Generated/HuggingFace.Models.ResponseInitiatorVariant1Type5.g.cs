
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseInitiatorVariant1Type5
    {
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Org,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseInitiatorVariant1Type5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseInitiatorVariant1Type5 value)
        {
            return value switch
            {
                ResponseInitiatorVariant1Type5.User => "user",
                ResponseInitiatorVariant1Type5.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseInitiatorVariant1Type5? ToEnum(string value)
        {
            return value switch
            {
                "user" => ResponseInitiatorVariant1Type5.User,
                "org" => ResponseInitiatorVariant1Type5.Org,
                _ => null,
            };
        }
    }
}