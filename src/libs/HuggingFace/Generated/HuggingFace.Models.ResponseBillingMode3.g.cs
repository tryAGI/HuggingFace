
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseBillingMode3
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
    public static class ResponseBillingMode3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseBillingMode3 value)
        {
            return value switch
            {
                ResponseBillingMode3.Prepaid => "prepaid",
                ResponseBillingMode3.Postpaid => "postpaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseBillingMode3? ToEnum(string value)
        {
            return value switch
            {
                "prepaid" => ResponseBillingMode3.Prepaid,
                "postpaid" => ResponseBillingMode3.Postpaid,
                _ => null,
            };
        }
    }
}