
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseInitiatorVariant1Type2
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
    public static class ResponseInitiatorVariant1Type2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseInitiatorVariant1Type2 value)
        {
            return value switch
            {
                ResponseInitiatorVariant1Type2.User => "user",
                ResponseInitiatorVariant1Type2.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseInitiatorVariant1Type2? ToEnum(string value)
        {
            return value switch
            {
                "user" => ResponseInitiatorVariant1Type2.User,
                "org" => ResponseInitiatorVariant1Type2.Org,
                _ => null,
            };
        }
    }
}