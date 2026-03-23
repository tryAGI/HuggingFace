
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOauthUserinfoResponseOrgBillingMode
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
    public static class CreateOauthUserinfoResponseOrgBillingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOauthUserinfoResponseOrgBillingMode value)
        {
            return value switch
            {
                CreateOauthUserinfoResponseOrgBillingMode.Postpaid => "postpaid",
                CreateOauthUserinfoResponseOrgBillingMode.Prepaid => "prepaid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOauthUserinfoResponseOrgBillingMode? ToEnum(string value)
        {
            return value switch
            {
                "postpaid" => CreateOauthUserinfoResponseOrgBillingMode.Postpaid,
                "prepaid" => CreateOauthUserinfoResponseOrgBillingMode.Prepaid,
                _ => null,
            };
        }
    }
}