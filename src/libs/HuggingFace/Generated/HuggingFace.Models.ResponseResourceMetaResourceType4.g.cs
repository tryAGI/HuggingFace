
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseResourceMetaResourceType4
    {
        /// <summary>
        /// 
        /// </summary>
        Group,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseResourceMetaResourceType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseResourceMetaResourceType4 value)
        {
            return value switch
            {
                ResponseResourceMetaResourceType4.Group => "Group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseResourceMetaResourceType4? ToEnum(string value)
        {
            return value switch
            {
                "Group" => ResponseResourceMetaResourceType4.Group,
                _ => null,
            };
        }
    }
}