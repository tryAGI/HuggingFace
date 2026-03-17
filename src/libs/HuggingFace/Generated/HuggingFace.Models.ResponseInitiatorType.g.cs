
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseInitiatorType
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
    public static class ResponseInitiatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseInitiatorType value)
        {
            return value switch
            {
                ResponseInitiatorType.User => "user",
                ResponseInitiatorType.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseInitiatorType? ToEnum(string value)
        {
            return value switch
            {
                "user" => ResponseInitiatorType.User,
                "org" => ResponseInitiatorType.Org,
                _ => null,
            };
        }
    }
}