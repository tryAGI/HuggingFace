
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchOrganizationsResourceGroupsUsersRequestVariant1Role
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
    public static class PatchOrganizationsResourceGroupsUsersRequestVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsResourceGroupsUsersRequestVariant1Role value)
        {
            return value switch
            {
                PatchOrganizationsResourceGroupsUsersRequestVariant1Role.Admin => "admin",
                PatchOrganizationsResourceGroupsUsersRequestVariant1Role.Contributor => "contributor",
                PatchOrganizationsResourceGroupsUsersRequestVariant1Role.NoAccess => "no_access",
                PatchOrganizationsResourceGroupsUsersRequestVariant1Role.Read => "read",
                PatchOrganizationsResourceGroupsUsersRequestVariant1Role.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsResourceGroupsUsersRequestVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PatchOrganizationsResourceGroupsUsersRequestVariant1Role.Admin,
                "contributor" => PatchOrganizationsResourceGroupsUsersRequestVariant1Role.Contributor,
                "no_access" => PatchOrganizationsResourceGroupsUsersRequestVariant1Role.NoAccess,
                "read" => PatchOrganizationsResourceGroupsUsersRequestVariant1Role.Read,
                "write" => PatchOrganizationsResourceGroupsUsersRequestVariant1Role.Write,
                _ => null,
            };
        }
    }
}