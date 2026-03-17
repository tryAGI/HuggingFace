
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GrammarTypeVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GrammarTypeVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GrammarTypeVariant3Type value)
        {
            return value switch
            {
                GrammarTypeVariant3Type.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GrammarTypeVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => GrammarTypeVariant3Type.JsonSchema,
                _ => null,
            };
        }
    }
}