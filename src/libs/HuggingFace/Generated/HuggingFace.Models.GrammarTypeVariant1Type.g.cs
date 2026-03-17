
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GrammarTypeVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GrammarTypeVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GrammarTypeVariant1Type value)
        {
            return value switch
            {
                GrammarTypeVariant1Type.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GrammarTypeVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "json" => GrammarTypeVariant1Type.Json,
                _ => null,
            };
        }
    }
}