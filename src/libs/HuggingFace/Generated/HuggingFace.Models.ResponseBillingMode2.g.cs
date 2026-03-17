
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Whether the user is on prepaid or postpaid billing
    /// </summary>
    public enum ResponseBillingMode2
    {
        /// <summary>
        /// 
        /// </summary>
        Prepaid,
        /// <summary>
        /// 
        /// </summary>
        Postpaid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseBillingMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseBillingMode2 value)
        {
            return value switch
            {
                ResponseBillingMode2.Prepaid => "prepaid",
                ResponseBillingMode2.Postpaid => "postpaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseBillingMode2? ToEnum(string value)
        {
            return value switch
            {
                "prepaid" => ResponseBillingMode2.Prepaid,
                "postpaid" => ResponseBillingMode2.Postpaid,
                _ => null,
            };
        }
    }
}