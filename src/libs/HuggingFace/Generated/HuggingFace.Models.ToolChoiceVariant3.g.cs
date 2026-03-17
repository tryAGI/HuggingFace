
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Means the model must call one or more tools.
    /// </summary>
    public enum ToolChoiceVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolChoiceVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceVariant3 value)
        {
            return value switch
            {
                ToolChoiceVariant3.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceVariant3? ToEnum(string value)
        {
            return value switch
            {
                "required" => ToolChoiceVariant3.Required,
                _ => null,
            };
        }
    }
}