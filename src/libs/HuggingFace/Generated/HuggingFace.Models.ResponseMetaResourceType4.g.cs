
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseMetaResourceType4
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseMetaResourceType4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseMetaResourceType4 value)
        {
            return value switch
            {
                ResponseMetaResourceType4.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseMetaResourceType4? ToEnum(string value)
        {
            return value switch
            {
                "User" => ResponseMetaResourceType4.User,
                _ => null,
            };
        }
    }
}