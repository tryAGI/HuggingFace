
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseMetaResourceType11
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseMetaResourceType11Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseMetaResourceType11 value)
        {
            return value switch
            {
                ResponseMetaResourceType11.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseMetaResourceType11? ToEnum(string value)
        {
            return value switch
            {
                "User" => ResponseMetaResourceType11.User,
                _ => null,
            };
        }
    }
}