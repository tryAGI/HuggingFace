
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOauthUserinfoResponseOrgBillingMode
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
    public static class GetOauthUserinfoResponseOrgBillingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOauthUserinfoResponseOrgBillingMode value)
        {
            return value switch
            {
                GetOauthUserinfoResponseOrgBillingMode.Postpaid => "postpaid",
                GetOauthUserinfoResponseOrgBillingMode.Prepaid => "prepaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOauthUserinfoResponseOrgBillingMode? ToEnum(string value)
        {
            return value switch
            {
                "postpaid" => GetOauthUserinfoResponseOrgBillingMode.Postpaid,
                "prepaid" => GetOauthUserinfoResponseOrgBillingMode.Prepaid,
                _ => null,
            };
        }
    }
}