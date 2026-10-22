
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationsResourceGroupsResponseItemUserAssignedRole
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
    public static class GetOrganizationsResourceGroupsResponseItemUserAssignedRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsResourceGroupsResponseItemUserAssignedRole value)
        {
            return value switch
            {
                GetOrganizationsResourceGroupsResponseItemUserAssignedRole.Admin => "admin",
                GetOrganizationsResourceGroupsResponseItemUserAssignedRole.Contributor => "contributor",
                GetOrganizationsResourceGroupsResponseItemUserAssignedRole.Inherit => "inherit",
                GetOrganizationsResourceGroupsResponseItemUserAssignedRole.NoAccess => "no_access",
                GetOrganizationsResourceGroupsResponseItemUserAssignedRole.Read => "read",
                GetOrganizationsResourceGroupsResponseItemUserAssignedRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsResourceGroupsResponseItemUserAssignedRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetOrganizationsResourceGroupsResponseItemUserAssignedRole.Admin,
                "contributor" => GetOrganizationsResourceGroupsResponseItemUserAssignedRole.Contributor,
                "inherit" => GetOrganizationsResourceGroupsResponseItemUserAssignedRole.Inherit,
                "no_access" => GetOrganizationsResourceGroupsResponseItemUserAssignedRole.NoAccess,
                "read" => GetOrganizationsResourceGroupsResponseItemUserAssignedRole.Read,
                "write" => GetOrganizationsResourceGroupsResponseItemUserAssignedRole.Write,
                _ => null,
            };
        }
    }
}