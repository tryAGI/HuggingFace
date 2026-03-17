
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOrgBillingMode
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
    public static class ResponseOrgBillingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOrgBillingMode value)
        {
            return value switch
            {
                ResponseOrgBillingMode.Prepaid => "prepaid",
                ResponseOrgBillingMode.Postpaid => "postpaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOrgBillingMode? ToEnum(string value)
        {
            return value switch
            {
                "prepaid" => ResponseOrgBillingMode.Prepaid,
                "postpaid" => ResponseOrgBillingMode.Postpaid,
                _ => null,
            };
        }
    }
}