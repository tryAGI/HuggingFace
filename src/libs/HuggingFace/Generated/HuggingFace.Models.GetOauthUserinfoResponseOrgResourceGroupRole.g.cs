
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOauthUserinfoResponseOrgResourceGroupRole
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
    public static class GetOauthUserinfoResponseOrgResourceGroupRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOauthUserinfoResponseOrgResourceGroupRole value)
        {
            return value switch
            {
                GetOauthUserinfoResponseOrgResourceGroupRole.Admin => "admin",
                GetOauthUserinfoResponseOrgResourceGroupRole.Contributor => "contributor",
                GetOauthUserinfoResponseOrgResourceGroupRole.Read => "read",
                GetOauthUserinfoResponseOrgResourceGroupRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOauthUserinfoResponseOrgResourceGroupRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetOauthUserinfoResponseOrgResourceGroupRole.Admin,
                "contributor" => GetOauthUserinfoResponseOrgResourceGroupRole.Contributor,
                "read" => GetOauthUserinfoResponseOrgResourceGroupRole.Read,
                "write" => GetOauthUserinfoResponseOrgResourceGroupRole.Write,
                _ => null,
            };
        }
    }
}