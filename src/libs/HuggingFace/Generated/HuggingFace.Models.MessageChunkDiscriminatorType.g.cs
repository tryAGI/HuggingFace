
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageChunkDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageChunkDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageChunkDiscriminatorType value)
        {
            return value switch
            {
                MessageChunkDiscriminatorType.ImageUrl => "image_url",
                MessageChunkDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageChunkDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => MessageChunkDiscriminatorType.ImageUrl,
                "text" => MessageChunkDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}