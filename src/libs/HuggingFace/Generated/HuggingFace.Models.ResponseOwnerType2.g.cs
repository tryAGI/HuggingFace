
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOwnerType2
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
    public static class ResponseOwnerType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOwnerType2 value)
        {
            return value switch
            {
                ResponseOwnerType2.User => "user",
                ResponseOwnerType2.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOwnerType2? ToEnum(string value)
        {
            return value switch
            {
                "user" => ResponseOwnerType2.User,
                "org" => ResponseOwnerType2.Org,
                _ => null,
            };
        }
    }
}