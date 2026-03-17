
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Means the model can pick between generating a message or calling one or more tools.
    /// </summary>
    public enum ToolChoiceVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolChoiceVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceVariant1 value)
        {
            return value switch
            {
                ToolChoiceVariant1.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceVariant1? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ToolChoiceVariant1.Auto,
                _ => null,
            };
        }
    }
}