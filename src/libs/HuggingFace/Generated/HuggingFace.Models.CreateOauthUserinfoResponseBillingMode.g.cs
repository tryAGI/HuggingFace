
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Whether the user is on prepaid or postpaid billing
    /// </summary>
    public enum CreateOauthUserinfoResponseBillingMode
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
    public static class CreateOauthUserinfoResponseBillingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOauthUserinfoResponseBillingMode value)
        {
            return value switch
            {
                CreateOauthUserinfoResponseBillingMode.Postpaid => "postpaid",
                CreateOauthUserinfoResponseBillingMode.Prepaid => "prepaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOauthUserinfoResponseBillingMode? ToEnum(string value)
        {
            return value switch
            {
                "postpaid" => CreateOauthUserinfoResponseBillingMode.Postpaid,
                "prepaid" => CreateOauthUserinfoResponseBillingMode.Prepaid,
                _ => null,
            };
        }
    }
}