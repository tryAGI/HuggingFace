
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        Unhealthy,
        /// <summary>
        /// 
        /// </summary>
        Backend,
        /// <summary>
        /// 
        /// </summary>
        Overloaded,
        /// <summary>
        /// 
        /// </summary>
        Validation,
        /// <summary>
        /// 
        /// </summary>
        Tokenizer,
        /// <summary>
        /// 
        /// </summary>
        Empty,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ErrorType value)
        {
            return value switch
            {
                ErrorType.Unhealthy => "Unhealthy",
                ErrorType.Backend => "Backend",
                ErrorType.Overloaded => "Overloaded",
                ErrorType.Validation => "Validation",
                ErrorType.Tokenizer => "Tokenizer",
                ErrorType.Empty => "Empty",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ErrorType? ToEnum(string value)
        {
            return value switch
            {
                "Unhealthy" => ErrorType.Unhealthy,
                "Backend" => ErrorType.Backend,
                "Overloaded" => ErrorType.Overloaded,
                "Validation" => ErrorType.Validation,
                "Tokenizer" => ErrorType.Tokenizer,
                "Empty" => ErrorType.Empty,
                _ => null,
            };
        }
    }
}