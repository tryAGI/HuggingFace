
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWhoamiV2ResponseOrgSecurityRestriction
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWhoamiV2ResponseOrgSecurityRestrictionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWhoamiV2ResponseOrgSecurityRestriction value)
        {
            return value switch
            {
                GetWhoamiV2ResponseOrgSecurityRestriction.Ip => "ip",
                GetWhoamiV2ResponseOrgSecurityRestriction.Mfa => "mfa",
                GetWhoamiV2ResponseOrgSecurityRestriction.Sso => "sso",
                GetWhoamiV2ResponseOrgSecurityRestriction.TokenPolicy => "token-policy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWhoamiV2ResponseOrgSecurityRestriction? ToEnum(string value)
        {
            return value switch
            {
                "ip" => GetWhoamiV2ResponseOrgSecurityRestriction.Ip,
                "mfa" => GetWhoamiV2ResponseOrgSecurityRestriction.Mfa,
                "sso" => GetWhoamiV2ResponseOrgSecurityRestriction.Sso,
                "token-policy" => GetWhoamiV2ResponseOrgSecurityRestriction.TokenPolicy,
                _ => null,
            };
        }
    }
}