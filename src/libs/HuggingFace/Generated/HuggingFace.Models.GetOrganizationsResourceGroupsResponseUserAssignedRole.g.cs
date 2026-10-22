
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationsResourceGroupsResponseUserAssignedRole
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
    public static class GetOrganizationsResourceGroupsResponseUserAssignedRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsResourceGroupsResponseUserAssignedRole value)
        {
            return value switch
            {
                GetOrganizationsResourceGroupsResponseUserAssignedRole.Admin => "admin",
                GetOrganizationsResourceGroupsResponseUserAssignedRole.Contributor => "contributor",
                GetOrganizationsResourceGroupsResponseUserAssignedRole.Inherit => "inherit",
                GetOrganizationsResourceGroupsResponseUserAssignedRole.NoAccess => "no_access",
                GetOrganizationsResourceGroupsResponseUserAssignedRole.Read => "read",
                GetOrganizationsResourceGroupsResponseUserAssignedRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsResourceGroupsResponseUserAssignedRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetOrganizationsResourceGroupsResponseUserAssignedRole.Admin,
                "contributor" => GetOrganizationsResourceGroupsResponseUserAssignedRole.Contributor,
                "inherit" => GetOrganizationsResourceGroupsResponseUserAssignedRole.Inherit,
                "no_access" => GetOrganizationsResourceGroupsResponseUserAssignedRole.NoAccess,
                "read" => GetOrganizationsResourceGroupsResponseUserAssignedRole.Read,
                "write" => GetOrganizationsResourceGroupsResponseUserAssignedRole.Write,
                _ => null,
            };
        }
    }
}