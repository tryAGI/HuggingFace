
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationsMembersResponseItemResourceGroupAssignedRole
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
    public static class GetOrganizationsMembersResponseItemResourceGroupAssignedRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsMembersResponseItemResourceGroupAssignedRole value)
        {
            return value switch
            {
                GetOrganizationsMembersResponseItemResourceGroupAssignedRole.Admin => "admin",
                GetOrganizationsMembersResponseItemResourceGroupAssignedRole.Contributor => "contributor",
                GetOrganizationsMembersResponseItemResourceGroupAssignedRole.Inherit => "inherit",
                GetOrganizationsMembersResponseItemResourceGroupAssignedRole.NoAccess => "no_access",
                GetOrganizationsMembersResponseItemResourceGroupAssignedRole.Read => "read",
                GetOrganizationsMembersResponseItemResourceGroupAssignedRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsMembersResponseItemResourceGroupAssignedRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetOrganizationsMembersResponseItemResourceGroupAssignedRole.Admin,
                "contributor" => GetOrganizationsMembersResponseItemResourceGroupAssignedRole.Contributor,
                "inherit" => GetOrganizationsMembersResponseItemResourceGroupAssignedRole.Inherit,
                "no_access" => GetOrganizationsMembersResponseItemResourceGroupAssignedRole.NoAccess,
                "read" => GetOrganizationsMembersResponseItemResourceGroupAssignedRole.Read,
                "write" => GetOrganizationsMembersResponseItemResourceGroupAssignedRole.Write,
                _ => null,
            };
        }
    }
}