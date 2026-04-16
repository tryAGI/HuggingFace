
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOauthUserinfoResponseOrgResourceGroupRole
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
        NoAccess,
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
    public static class CreateOauthUserinfoResponseOrgResourceGroupRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOauthUserinfoResponseOrgResourceGroupRole value)
        {
            return value switch
            {
                CreateOauthUserinfoResponseOrgResourceGroupRole.Admin => "admin",
                CreateOauthUserinfoResponseOrgResourceGroupRole.Contributor => "contributor",
                CreateOauthUserinfoResponseOrgResourceGroupRole.NoAccess => "no_access",
                CreateOauthUserinfoResponseOrgResourceGroupRole.Read => "read",
                CreateOauthUserinfoResponseOrgResourceGroupRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOauthUserinfoResponseOrgResourceGroupRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOauthUserinfoResponseOrgResourceGroupRole.Admin,
                "contributor" => CreateOauthUserinfoResponseOrgResourceGroupRole.Contributor,
                "no_access" => CreateOauthUserinfoResponseOrgResourceGroupRole.NoAccess,
                "read" => CreateOauthUserinfoResponseOrgResourceGroupRole.Read,
                "write" => CreateOauthUserinfoResponseOrgResourceGroupRole.Write,
                _ => null,
            };
        }
    }
}