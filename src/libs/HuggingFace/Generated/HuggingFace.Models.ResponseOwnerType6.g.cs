
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOwnerType6
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
    public static class ResponseOwnerType6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOwnerType6 value)
        {
            return value switch
            {
                ResponseOwnerType6.User => "user",
                ResponseOwnerType6.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOwnerType6? ToEnum(string value)
        {
            return value switch
            {
                "user" => ResponseOwnerType6.User,
                "org" => ResponseOwnerType6.Org,
                _ => null,
            };
        }
    }
}