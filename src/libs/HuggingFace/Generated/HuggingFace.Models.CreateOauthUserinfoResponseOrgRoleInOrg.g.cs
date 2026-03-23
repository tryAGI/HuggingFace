
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOauthUserinfoResponseOrgRoleInOrg
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
    public static class CreateOauthUserinfoResponseOrgRoleInOrgExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOauthUserinfoResponseOrgRoleInOrg value)
        {
            return value switch
            {
                CreateOauthUserinfoResponseOrgRoleInOrg.Admin => "admin",
                CreateOauthUserinfoResponseOrgRoleInOrg.Contributor => "contributor",
                CreateOauthUserinfoResponseOrgRoleInOrg.Read => "read",
                CreateOauthUserinfoResponseOrgRoleInOrg.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOauthUserinfoResponseOrgRoleInOrg? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOauthUserinfoResponseOrgRoleInOrg.Admin,
                "contributor" => CreateOauthUserinfoResponseOrgRoleInOrg.Contributor,
                "read" => CreateOauthUserinfoResponseOrgRoleInOrg.Read,
                "write" => CreateOauthUserinfoResponseOrgRoleInOrg.Write,
                _ => null,
            };
        }
    }
}