
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationsResourceGroupsResponseItemUserOrgRole
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
    public static class GetOrganizationsResourceGroupsResponseItemUserOrgRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsResourceGroupsResponseItemUserOrgRole value)
        {
            return value switch
            {
                GetOrganizationsResourceGroupsResponseItemUserOrgRole.Admin => "admin",
                GetOrganizationsResourceGroupsResponseItemUserOrgRole.Contributor => "contributor",
                GetOrganizationsResourceGroupsResponseItemUserOrgRole.NoAccess => "no_access",
                GetOrganizationsResourceGroupsResponseItemUserOrgRole.Read => "read",
                GetOrganizationsResourceGroupsResponseItemUserOrgRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsResourceGroupsResponseItemUserOrgRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetOrganizationsResourceGroupsResponseItemUserOrgRole.Admin,
                "contributor" => GetOrganizationsResourceGroupsResponseItemUserOrgRole.Contributor,
                "no_access" => GetOrganizationsResourceGroupsResponseItemUserOrgRole.NoAccess,
                "read" => GetOrganizationsResourceGroupsResponseItemUserOrgRole.Read,
                "write" => GetOrganizationsResourceGroupsResponseItemUserOrgRole.Write,
                _ => null,
            };
        }
    }
}