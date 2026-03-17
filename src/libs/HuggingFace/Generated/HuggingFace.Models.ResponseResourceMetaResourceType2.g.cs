
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseResourceMetaResourceType2
    {
        /// <summary>
        /// 
        /// </summary>
        Group,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseResourceMetaResourceType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseResourceMetaResourceType2 value)
        {
            return value switch
            {
                ResponseResourceMetaResourceType2.Group => "Group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseResourceMetaResourceType2? ToEnum(string value)
        {
            return value switch
            {
                "Group" => ResponseResourceMetaResourceType2.Group,
                _ => null,
            };
        }
    }
}