
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponsePeriodEntityType
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
    public static class ResponsePeriodEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponsePeriodEntityType value)
        {
            return value switch
            {
                ResponsePeriodEntityType.User => "user",
                ResponsePeriodEntityType.Org => "org",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponsePeriodEntityType? ToEnum(string value)
        {
            return value switch
            {
                "user" => ResponsePeriodEntityType.User,
                "org" => ResponsePeriodEntityType.Org,
                _ => null,
            };
        }
    }
}