
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchOrganizationsResourceGroupsResponseUserOrgRole
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
    public static class PatchOrganizationsResourceGroupsResponseUserOrgRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsResourceGroupsResponseUserOrgRole value)
        {
            return value switch
            {
                PatchOrganizationsResourceGroupsResponseUserOrgRole.Admin => "admin",
                PatchOrganizationsResourceGroupsResponseUserOrgRole.Contributor => "contributor",
                PatchOrganizationsResourceGroupsResponseUserOrgRole.NoAccess => "no_access",
                PatchOrganizationsResourceGroupsResponseUserOrgRole.Read => "read",
                PatchOrganizationsResourceGroupsResponseUserOrgRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsResourceGroupsResponseUserOrgRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PatchOrganizationsResourceGroupsResponseUserOrgRole.Admin,
                "contributor" => PatchOrganizationsResourceGroupsResponseUserOrgRole.Contributor,
                "no_access" => PatchOrganizationsResourceGroupsResponseUserOrgRole.NoAccess,
                "read" => PatchOrganizationsResourceGroupsResponseUserOrgRole.Read,
                "write" => PatchOrganizationsResourceGroupsResponseUserOrgRole.Write,
                _ => null,
            };
        }
    }
}