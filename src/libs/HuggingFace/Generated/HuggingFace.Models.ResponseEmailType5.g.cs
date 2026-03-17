
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// We only support work emails, other types are converted to work
    /// </summary>
    public enum ResponseEmailType5
    {
        /// <summary>
        /// 
        /// </summary>
        Work,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseEmailType5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseEmailType5 value)
        {
            return value switch
            {
                ResponseEmailType5.Work => "work",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseEmailType5? ToEnum(string value)
        {
            return value switch
            {
                "work" => ResponseEmailType5.Work,
                _ => null,
            };
        }
    }
}