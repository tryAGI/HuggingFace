
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateOrganizationsResourceGroupsResponseUserAssignedRole
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
    public static class CreateOrganizationsResourceGroupsResponseUserAssignedRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsResponseUserAssignedRole value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsResponseUserAssignedRole.Admin => "admin",
                CreateOrganizationsResourceGroupsResponseUserAssignedRole.Contributor => "contributor",
                CreateOrganizationsResourceGroupsResponseUserAssignedRole.Inherit => "inherit",
                CreateOrganizationsResourceGroupsResponseUserAssignedRole.NoAccess => "no_access",
                CreateOrganizationsResourceGroupsResponseUserAssignedRole.Read => "read",
                CreateOrganizationsResourceGroupsResponseUserAssignedRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsResponseUserAssignedRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsResponseUserAssignedRole.Admin,
                "contributor" => CreateOrganizationsResourceGroupsResponseUserAssignedRole.Contributor,
                "inherit" => CreateOrganizationsResourceGroupsResponseUserAssignedRole.Inherit,
                "no_access" => CreateOrganizationsResourceGroupsResponseUserAssignedRole.NoAccess,
                "read" => CreateOrganizationsResourceGroupsResponseUserAssignedRole.Read,
                "write" => CreateOrganizationsResourceGroupsResponseUserAssignedRole.Write,
                _ => null,
            };
        }
    }
}