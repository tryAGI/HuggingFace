
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsePeriodEntityType2
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
    public static class ResponsePeriodEntityType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsePeriodEntityType2 value)
        {
            return value switch
            {
                ResponsePeriodEntityType2.User => "user",
                ResponsePeriodEntityType2.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsePeriodEntityType2? ToEnum(string value)
        {
            return value switch
            {
                "user" => ResponsePeriodEntityType2.User,
                "org" => ResponsePeriodEntityType2.Org,
                _ => null,
            };
        }
    }
}