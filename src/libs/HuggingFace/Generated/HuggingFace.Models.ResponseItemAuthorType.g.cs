
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemAuthorType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemAuthorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemAuthorType value)
        {
            return value switch
            {
                ResponseItemAuthorType.User => "user",
                ResponseItemAuthorType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemAuthorType? ToEnum(string value)
        {
            return value switch
            {
                "user" => ResponseItemAuthorType.User,
                "system" => ResponseItemAuthorType.System,
                _ => null,
            };
        }
    }
}