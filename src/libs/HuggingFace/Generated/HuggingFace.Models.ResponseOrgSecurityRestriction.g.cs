
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOrgSecurityRestriction
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
    public static class ResponseOrgSecurityRestrictionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOrgSecurityRestriction value)
        {
            return value switch
            {
                ResponseOrgSecurityRestriction.Mfa => "mfa",
                ResponseOrgSecurityRestriction.TokenPolicy => "token-policy",
                ResponseOrgSecurityRestriction.Sso => "sso",
                ResponseOrgSecurityRestriction.Ip => "ip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOrgSecurityRestriction? ToEnum(string value)
        {
            return value switch
            {
                "mfa" => ResponseOrgSecurityRestriction.Mfa,
                "token-policy" => ResponseOrgSecurityRestriction.TokenPolicy,
                "sso" => ResponseOrgSecurityRestriction.Sso,
                "ip" => ResponseOrgSecurityRestriction.Ip,
                _ => null,
            };
        }
    }
}