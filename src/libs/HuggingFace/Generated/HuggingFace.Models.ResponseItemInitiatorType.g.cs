
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemInitiatorType
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
    public static class ResponseItemInitiatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemInitiatorType value)
        {
            return value switch
            {
                ResponseItemInitiatorType.User => "user",
                ResponseItemInitiatorType.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemInitiatorType? ToEnum(string value)
        {
            return value switch
            {
                "user" => ResponseItemInitiatorType.User,
                "org" => ResponseItemInitiatorType.Org,
                _ => null,
            };
        }
    }
}