
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// We only support work emails, other types are converted to work
    /// </summary>
    public enum ResponseEmailType2
    {
        /// <summary>
        /// 
        /// </summary>
        Work,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseEmailType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseEmailType2 value)
        {
            return value switch
            {
                ResponseEmailType2.Work => "work",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseEmailType2? ToEnum(string value)
        {
            return value switch
            {
                "work" => ResponseEmailType2.Work,
                _ => null,
            };
        }
    }
}