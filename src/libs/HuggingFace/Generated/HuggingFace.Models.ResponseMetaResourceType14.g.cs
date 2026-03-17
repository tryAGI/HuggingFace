
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseMetaResourceType14
    {
        /// <summary>
        /// 
        /// </summary>
        Group,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseMetaResourceType14Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseMetaResourceType14 value)
        {
            return value switch
            {
                ResponseMetaResourceType14.Group => "Group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseMetaResourceType14? ToEnum(string value)
        {
            return value switch
            {
                "Group" => ResponseMetaResourceType14.Group,
                _ => null,
            };
        }
    }
}