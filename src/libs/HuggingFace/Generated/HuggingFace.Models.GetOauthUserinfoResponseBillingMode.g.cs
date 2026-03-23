
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Whether the user is on prepaid or postpaid billing
    /// </summary>
    public enum GetOauthUserinfoResponseBillingMode
    {
        /// <summary>
        /// 
        /// </summary>
        Postpaid,
        /// <summary>
        /// 
        /// </summary>
        Prepaid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOauthUserinfoResponseBillingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOauthUserinfoResponseBillingMode value)
        {
            return value switch
            {
                GetOauthUserinfoResponseBillingMode.Postpaid => "postpaid",
                GetOauthUserinfoResponseBillingMode.Prepaid => "prepaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOauthUserinfoResponseBillingMode? ToEnum(string value)
        {
            return value switch
            {
                "postpaid" => GetOauthUserinfoResponseBillingMode.Postpaid,
                "prepaid" => GetOauthUserinfoResponseBillingMode.Prepaid,
                _ => null,
            };
        }
    }
}