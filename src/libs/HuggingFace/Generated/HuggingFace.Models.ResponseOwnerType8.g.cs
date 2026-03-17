
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOwnerType8
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
    public static class ResponseOwnerType8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOwnerType8 value)
        {
            return value switch
            {
                ResponseOwnerType8.User => "user",
                ResponseOwnerType8.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOwnerType8? ToEnum(string value)
        {
            return value switch
            {
                "user" => ResponseOwnerType8.User,
                "org" => ResponseOwnerType8.Org,
                _ => null,
            };
        }
    }
}