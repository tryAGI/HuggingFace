
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseMetaResourceType9
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseMetaResourceType9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseMetaResourceType9 value)
        {
            return value switch
            {
                ResponseMetaResourceType9.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseMetaResourceType9? ToEnum(string value)
        {
            return value switch
            {
                "User" => ResponseMetaResourceType9.User,
                _ => null,
            };
        }
    }
}