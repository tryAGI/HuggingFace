
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOrgBillingMode2
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
    public static class ResponseOrgBillingMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOrgBillingMode2 value)
        {
            return value switch
            {
                ResponseOrgBillingMode2.Prepaid => "prepaid",
                ResponseOrgBillingMode2.Postpaid => "postpaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOrgBillingMode2? ToEnum(string value)
        {
            return value switch
            {
                "prepaid" => ResponseOrgBillingMode2.Prepaid,
                "postpaid" => ResponseOrgBillingMode2.Postpaid,
                _ => null,
            };
        }
    }
}