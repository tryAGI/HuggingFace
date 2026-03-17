
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOrgSecurityRestriction2
    {
        /// <summary>
        /// 
        /// </summary>
        Mfa,
        /// <summary>
        /// 
        /// </summary>
        TokenPolicy,
        /// <summary>
        /// 
        /// </summary>
        Sso,
        /// <summary>
        /// 
        /// </summary>
        Ip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOrgSecurityRestriction2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOrgSecurityRestriction2 value)
        {
            return value switch
            {
                ResponseOrgSecurityRestriction2.Mfa => "mfa",
                ResponseOrgSecurityRestriction2.TokenPolicy => "token-policy",
                ResponseOrgSecurityRestriction2.Sso => "sso",
                ResponseOrgSecurityRestriction2.Ip => "ip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOrgSecurityRestriction2? ToEnum(string value)
        {
            return value switch
            {
                "mfa" => ResponseOrgSecurityRestriction2.Mfa,
                "token-policy" => ResponseOrgSecurityRestriction2.TokenPolicy,
                "sso" => ResponseOrgSecurityRestriction2.Sso,
                "ip" => ResponseOrgSecurityRestriction2.Ip,
                _ => null,
            };
        }
    }
}