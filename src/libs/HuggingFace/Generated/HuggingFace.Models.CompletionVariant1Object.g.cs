
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompletionVariant1Object
    {
        /// <summary>
        /// 
        /// </summary>
        TextCompletion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompletionVariant1ObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompletionVariant1Object value)
        {
            return value switch
            {
                CompletionVariant1Object.TextCompletion => "text_completion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompletionVariant1Object? ToEnum(string value)
        {
            return value switch
            {
                "text_completion" => CompletionVariant1Object.TextCompletion,
                _ => null,
            };
        }
    }
}