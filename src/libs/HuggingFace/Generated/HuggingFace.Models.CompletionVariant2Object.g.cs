
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompletionVariant2Object
    {
        /// <summary>
        /// 
        /// </summary>
        TextCompletion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionVariant2ObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionVariant2Object value)
        {
            return value switch
            {
                CompletionVariant2Object.TextCompletion => "text_completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionVariant2Object? ToEnum(string value)
        {
            return value switch
            {
                "text_completion" => CompletionVariant2Object.TextCompletion,
                _ => null,
            };
        }
    }
}