
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemInitiatorVariant1Type
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
    public static class ResponseItemInitiatorVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemInitiatorVariant1Type value)
        {
            return value switch
            {
                ResponseItemInitiatorVariant1Type.User => "user",
                ResponseItemInitiatorVariant1Type.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemInitiatorVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "user" => ResponseItemInitiatorVariant1Type.User,
                "org" => ResponseItemInitiatorVariant1Type.Org,
                _ => null,
            };
        }
    }
}