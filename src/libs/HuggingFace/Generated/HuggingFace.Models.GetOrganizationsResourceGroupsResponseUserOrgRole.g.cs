
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationsResourceGroupsResponseUserOrgRole
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
    public static class GetOrganizationsResourceGroupsResponseUserOrgRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsResourceGroupsResponseUserOrgRole value)
        {
            return value switch
            {
                GetOrganizationsResourceGroupsResponseUserOrgRole.Admin => "admin",
                GetOrganizationsResourceGroupsResponseUserOrgRole.Contributor => "contributor",
                GetOrganizationsResourceGroupsResponseUserOrgRole.NoAccess => "no_access",
                GetOrganizationsResourceGroupsResponseUserOrgRole.Read => "read",
                GetOrganizationsResourceGroupsResponseUserOrgRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsResourceGroupsResponseUserOrgRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetOrganizationsResourceGroupsResponseUserOrgRole.Admin,
                "contributor" => GetOrganizationsResourceGroupsResponseUserOrgRole.Contributor,
                "no_access" => GetOrganizationsResourceGroupsResponseUserOrgRole.NoAccess,
                "read" => GetOrganizationsResourceGroupsResponseUserOrgRole.Read,
                "write" => GetOrganizationsResourceGroupsResponseUserOrgRole.Write,
                _ => null,
            };
        }
    }
}