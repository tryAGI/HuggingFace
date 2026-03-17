
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Means the model will not call any tool and instead generates a message.
    /// </summary>
    public enum ToolChoiceVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolChoiceVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolChoiceVariant2 value)
        {
            return value switch
            {
                ToolChoiceVariant2.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolChoiceVariant2? ToEnum(string value)
        {
            return value switch
            {
                "none" => ToolChoiceVariant2.None,
                _ => null,
            };
        }
    }
}