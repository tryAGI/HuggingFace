
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Org,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemOwnerType value)
        {
            return value switch
            {
                ResponseItemOwnerType.User => "user",
                ResponseItemOwnerType.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "user" => ResponseItemOwnerType.User,
                "org" => ResponseItemOwnerType.Org,
                _ => null,
            };
        }
    }
}