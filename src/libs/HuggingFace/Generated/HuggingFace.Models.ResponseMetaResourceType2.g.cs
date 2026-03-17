
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseMetaResourceType2
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseMetaResourceType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseMetaResourceType2 value)
        {
            return value switch
            {
                ResponseMetaResourceType2.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseMetaResourceType2? ToEnum(string value)
        {
            return value switch
            {
                "User" => ResponseMetaResourceType2.User,
                _ => null,
            };
        }
    }
}