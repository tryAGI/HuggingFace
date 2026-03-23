
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
        Backend,
        /// <summary>
        /// 
        /// </summary>
        Empty,
        /// <summary>
        /// 
        /// </summary>
        Overloaded,
        /// <summary>
        /// 
        /// </summary>
        Tokenizer,
        /// <summary>
        /// 
        /// </summary>
        Unhealthy,
        /// <summary>
        /// 
        /// </summary>
        Validation,
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
                ErrorType.Backend => "Backend",
                ErrorType.Empty => "Empty",
                ErrorType.Overloaded => "Overloaded",
                ErrorType.Tokenizer => "Tokenizer",
                ErrorType.Unhealthy => "Unhealthy",
                ErrorType.Validation => "Validation",
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
                "Backend" => ErrorType.Backend,
                "Empty" => ErrorType.Empty,
                "Overloaded" => ErrorType.Overloaded,
                "Tokenizer" => ErrorType.Tokenizer,
                "Unhealthy" => ErrorType.Unhealthy,
                "Validation" => ErrorType.Validation,
                _ => null,
            };
        }
    }
}