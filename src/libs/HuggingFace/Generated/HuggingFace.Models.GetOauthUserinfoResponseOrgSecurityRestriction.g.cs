
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOauthUserinfoResponseOrgSecurityRestriction
    {
        /// <summary>
        /// 
        /// </summary>
        Ip,
        /// <summary>
        /// 
        /// </summary>
        Mfa,
        /// <summary>
        /// 
        /// </summary>
        Sso,
        /// <summary>
        /// 
        /// </summary>
        TokenPolicy,
        /// <summary>
        /// 
        /// </summary>
        TokenRevoked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOauthUserinfoResponseOrgSecurityRestrictionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOauthUserinfoResponseOrgSecurityRestriction value)
        {
            return value switch
            {
                GetOauthUserinfoResponseOrgSecurityRestriction.Ip => "ip",
                GetOauthUserinfoResponseOrgSecurityRestriction.Mfa => "mfa",
                GetOauthUserinfoResponseOrgSecurityRestriction.Sso => "sso",
                GetOauthUserinfoResponseOrgSecurityRestriction.TokenPolicy => "token-policy",
                GetOauthUserinfoResponseOrgSecurityRestriction.TokenRevoked => "token-revoked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOauthUserinfoResponseOrgSecurityRestriction? ToEnum(string value)
        {
            return value switch
            {
                "ip" => GetOauthUserinfoResponseOrgSecurityRestriction.Ip,
                "mfa" => GetOauthUserinfoResponseOrgSecurityRestriction.Mfa,
                "sso" => GetOauthUserinfoResponseOrgSecurityRestriction.Sso,
                "token-policy" => GetOauthUserinfoResponseOrgSecurityRestriction.TokenPolicy,
                "token-revoked" => GetOauthUserinfoResponseOrgSecurityRestriction.TokenRevoked,
                _ => null,
            };
        }
    }
}