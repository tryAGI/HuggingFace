
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// We only support work emails, other types are converted to work
    /// </summary>
    public enum ResponseResourceEmailType2
    {
        /// <summary>
        /// 
        /// </summary>
        Work,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseResourceEmailType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseResourceEmailType2 value)
        {
            return value switch
            {
                ResponseResourceEmailType2.Work => "work",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseResourceEmailType2? ToEnum(string value)
        {
            return value switch
            {
                "work" => ResponseResourceEmailType2.Work,
                _ => null,
            };
        }
    }
}