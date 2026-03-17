
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOrgSecurityRestriction3
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
    public static class ResponseOrgSecurityRestriction3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOrgSecurityRestriction3 value)
        {
            return value switch
            {
                ResponseOrgSecurityRestriction3.Mfa => "mfa",
                ResponseOrgSecurityRestriction3.TokenPolicy => "token-policy",
                ResponseOrgSecurityRestriction3.Sso => "sso",
                ResponseOrgSecurityRestriction3.Ip => "ip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOrgSecurityRestriction3? ToEnum(string value)
        {
            return value switch
            {
                "mfa" => ResponseOrgSecurityRestriction3.Mfa,
                "token-policy" => ResponseOrgSecurityRestriction3.TokenPolicy,
                "sso" => ResponseOrgSecurityRestriction3.Sso,
                "ip" => ResponseOrgSecurityRestriction3.Ip,
                _ => null,
            };
        }
    }
}