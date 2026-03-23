
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOauthUserinfoResponseOrgSecurityRestriction
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
    public static class CreateOauthUserinfoResponseOrgSecurityRestrictionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOauthUserinfoResponseOrgSecurityRestriction value)
        {
            return value switch
            {
                CreateOauthUserinfoResponseOrgSecurityRestriction.Ip => "ip",
                CreateOauthUserinfoResponseOrgSecurityRestriction.Mfa => "mfa",
                CreateOauthUserinfoResponseOrgSecurityRestriction.Sso => "sso",
                CreateOauthUserinfoResponseOrgSecurityRestriction.TokenPolicy => "token-policy",
                CreateOauthUserinfoResponseOrgSecurityRestriction.TokenRevoked => "token-revoked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOauthUserinfoResponseOrgSecurityRestriction? ToEnum(string value)
        {
            return value switch
            {
                "ip" => CreateOauthUserinfoResponseOrgSecurityRestriction.Ip,
                "mfa" => CreateOauthUserinfoResponseOrgSecurityRestriction.Mfa,
                "sso" => CreateOauthUserinfoResponseOrgSecurityRestriction.Sso,
                "token-policy" => CreateOauthUserinfoResponseOrgSecurityRestriction.TokenPolicy,
                "token-revoked" => CreateOauthUserinfoResponseOrgSecurityRestriction.TokenRevoked,
                _ => null,
            };
        }
    }
}