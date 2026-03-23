
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOauthUserinfoResponseOrgRoleInOrg
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Contributor,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOauthUserinfoResponseOrgRoleInOrgExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOauthUserinfoResponseOrgRoleInOrg value)
        {
            return value switch
            {
                GetOauthUserinfoResponseOrgRoleInOrg.Admin => "admin",
                GetOauthUserinfoResponseOrgRoleInOrg.Contributor => "contributor",
                GetOauthUserinfoResponseOrgRoleInOrg.Read => "read",
                GetOauthUserinfoResponseOrgRoleInOrg.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOauthUserinfoResponseOrgRoleInOrg? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetOauthUserinfoResponseOrgRoleInOrg.Admin,
                "contributor" => GetOauthUserinfoResponseOrgRoleInOrg.Contributor,
                "read" => GetOauthUserinfoResponseOrgRoleInOrg.Read,
                "write" => GetOauthUserinfoResponseOrgRoleInOrg.Write,
                _ => null,
            };
        }
    }
}