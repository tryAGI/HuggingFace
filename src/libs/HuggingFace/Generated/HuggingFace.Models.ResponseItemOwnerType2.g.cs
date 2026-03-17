
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemOwnerType2
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
    public static class ResponseItemOwnerType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemOwnerType2 value)
        {
            return value switch
            {
                ResponseItemOwnerType2.User => "user",
                ResponseItemOwnerType2.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemOwnerType2? ToEnum(string value)
        {
            return value switch
            {
                "user" => ResponseItemOwnerType2.User,
                "org" => ResponseItemOwnerType2.Org,
                _ => null,
            };
        }
    }
}