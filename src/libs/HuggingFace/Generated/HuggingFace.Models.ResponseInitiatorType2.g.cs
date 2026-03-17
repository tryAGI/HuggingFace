
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseInitiatorType2
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
    public static class ResponseInitiatorType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseInitiatorType2 value)
        {
            return value switch
            {
                ResponseInitiatorType2.User => "user",
                ResponseInitiatorType2.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseInitiatorType2? ToEnum(string value)
        {
            return value switch
            {
                "user" => ResponseInitiatorType2.User,
                "org" => ResponseInitiatorType2.Org,
                _ => null,
            };
        }
    }
}