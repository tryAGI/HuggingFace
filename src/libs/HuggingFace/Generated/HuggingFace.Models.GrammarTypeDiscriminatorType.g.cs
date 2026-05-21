
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GrammarTypeDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
        /// <summary>
        /// 
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GrammarTypeDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GrammarTypeDiscriminatorType value)
        {
            return value switch
            {
                GrammarTypeDiscriminatorType.Json => "json",
                GrammarTypeDiscriminatorType.JsonSchema => "json_schema",
                GrammarTypeDiscriminatorType.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GrammarTypeDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json" => GrammarTypeDiscriminatorType.Json,
                "json_schema" => GrammarTypeDiscriminatorType.JsonSchema,
                "regex" => GrammarTypeDiscriminatorType.Regex,
                _ => null,
            };
        }
    }
}