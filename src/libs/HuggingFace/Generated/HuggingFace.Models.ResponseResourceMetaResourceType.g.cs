
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseResourceMetaResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseResourceMetaResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseResourceMetaResourceType value)
        {
            return value switch
            {
                ResponseResourceMetaResourceType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseResourceMetaResourceType? ToEnum(string value)
        {
            return value switch
            {
                "User" => ResponseResourceMetaResourceType.User,
                _ => null,
            };
        }
    }
}