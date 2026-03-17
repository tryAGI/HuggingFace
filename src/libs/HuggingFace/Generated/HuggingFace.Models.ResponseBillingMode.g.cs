
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Whether the user is on prepaid or postpaid billing
    /// </summary>
    public enum ResponseBillingMode
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
    public static class ResponseBillingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseBillingMode value)
        {
            return value switch
            {
                ResponseBillingMode.Prepaid => "prepaid",
                ResponseBillingMode.Postpaid => "postpaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseBillingMode? ToEnum(string value)
        {
            return value switch
            {
                "prepaid" => ResponseBillingMode.Prepaid,
                "postpaid" => ResponseBillingMode.Postpaid,
                _ => null,
            };
        }
    }
}