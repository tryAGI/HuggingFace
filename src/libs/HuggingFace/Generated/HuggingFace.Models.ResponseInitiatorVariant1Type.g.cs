
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseInitiatorVariant1Type
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
    public static class ResponseInitiatorVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseInitiatorVariant1Type value)
        {
            return value switch
            {
                ResponseInitiatorVariant1Type.User => "user",
                ResponseInitiatorVariant1Type.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseInitiatorVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "user" => ResponseInitiatorVariant1Type.User,
                "org" => ResponseInitiatorVariant1Type.Org,
                _ => null,
            };
        }
    }
}