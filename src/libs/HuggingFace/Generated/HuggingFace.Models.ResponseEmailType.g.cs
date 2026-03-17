
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// We only support work emails, other types are converted to work
    /// </summary>
    public enum ResponseEmailType
    {
        /// <summary>
        /// 
        /// </summary>
        Work,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseEmailTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseEmailType value)
        {
            return value switch
            {
                ResponseEmailType.Work => "work",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseEmailType? ToEnum(string value)
        {
            return value switch
            {
                "work" => ResponseEmailType.Work,
                _ => null,
            };
        }
    }
}