
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetWhoamiV2ResponseOrgRoleInOrg
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
    public static class GetWhoamiV2ResponseOrgRoleInOrgExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWhoamiV2ResponseOrgRoleInOrg value)
        {
            return value switch
            {
                GetWhoamiV2ResponseOrgRoleInOrg.Admin => "admin",
                GetWhoamiV2ResponseOrgRoleInOrg.Contributor => "contributor",
                GetWhoamiV2ResponseOrgRoleInOrg.Read => "read",
                GetWhoamiV2ResponseOrgRoleInOrg.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWhoamiV2ResponseOrgRoleInOrg? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetWhoamiV2ResponseOrgRoleInOrg.Admin,
                "contributor" => GetWhoamiV2ResponseOrgRoleInOrg.Contributor,
                "read" => GetWhoamiV2ResponseOrgRoleInOrg.Read,
                "write" => GetWhoamiV2ResponseOrgRoleInOrg.Write,
                _ => null,
            };
        }
    }
}