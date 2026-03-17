
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GrammarTypeVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GrammarTypeVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GrammarTypeVariant2Type value)
        {
            return value switch
            {
                GrammarTypeVariant2Type.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GrammarTypeVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "regex" => GrammarTypeVariant2Type.Regex,
                _ => null,
            };
        }
    }
}