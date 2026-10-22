
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchOrganizationsResourceGroupsResponseUserAssignedRole
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
        Inherit,
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
    public static class PatchOrganizationsResourceGroupsResponseUserAssignedRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsResourceGroupsResponseUserAssignedRole value)
        {
            return value switch
            {
                PatchOrganizationsResourceGroupsResponseUserAssignedRole.Admin => "admin",
                PatchOrganizationsResourceGroupsResponseUserAssignedRole.Contributor => "contributor",
                PatchOrganizationsResourceGroupsResponseUserAssignedRole.Inherit => "inherit",
                PatchOrganizationsResourceGroupsResponseUserAssignedRole.NoAccess => "no_access",
                PatchOrganizationsResourceGroupsResponseUserAssignedRole.Read => "read",
                PatchOrganizationsResourceGroupsResponseUserAssignedRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsResourceGroupsResponseUserAssignedRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PatchOrganizationsResourceGroupsResponseUserAssignedRole.Admin,
                "contributor" => PatchOrganizationsResourceGroupsResponseUserAssignedRole.Contributor,
                "inherit" => PatchOrganizationsResourceGroupsResponseUserAssignedRole.Inherit,
                "no_access" => PatchOrganizationsResourceGroupsResponseUserAssignedRole.NoAccess,
                "read" => PatchOrganizationsResourceGroupsResponseUserAssignedRole.Read,
                "write" => PatchOrganizationsResourceGroupsResponseUserAssignedRole.Write,
                _ => null,
            };
        }
    }
}