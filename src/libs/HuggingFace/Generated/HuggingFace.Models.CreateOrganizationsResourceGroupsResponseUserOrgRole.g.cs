
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateOrganizationsResourceGroupsResponseUserOrgRole
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
    public static class CreateOrganizationsResourceGroupsResponseUserOrgRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsResponseUserOrgRole value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsResponseUserOrgRole.Admin => "admin",
                CreateOrganizationsResourceGroupsResponseUserOrgRole.Contributor => "contributor",
                CreateOrganizationsResourceGroupsResponseUserOrgRole.NoAccess => "no_access",
                CreateOrganizationsResourceGroupsResponseUserOrgRole.Read => "read",
                CreateOrganizationsResourceGroupsResponseUserOrgRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsResponseUserOrgRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsResponseUserOrgRole.Admin,
                "contributor" => CreateOrganizationsResourceGroupsResponseUserOrgRole.Contributor,
                "no_access" => CreateOrganizationsResourceGroupsResponseUserOrgRole.NoAccess,
                "read" => CreateOrganizationsResourceGroupsResponseUserOrgRole.Read,
                "write" => CreateOrganizationsResourceGroupsResponseUserOrgRole.Write,
                _ => null,
            };
        }
    }
}