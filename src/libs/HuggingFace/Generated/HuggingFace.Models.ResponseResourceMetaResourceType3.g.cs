
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseResourceMetaResourceType3
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseResourceMetaResourceType3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseResourceMetaResourceType3 value)
        {
            return value switch
            {
                ResponseResourceMetaResourceType3.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseResourceMetaResourceType3? ToEnum(string value)
        {
            return value switch
            {
                "User" => ResponseResourceMetaResourceType3.User,
                _ => null,
            };
        }
    }
}