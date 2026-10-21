
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Organization role the invitee joins with
    /// </summary>
    public enum CreateOrganizationsResourceGroupsInviteResponseRole
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
    public static class CreateOrganizationsResourceGroupsInviteResponseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsInviteResponseRole value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsInviteResponseRole.Admin => "admin",
                CreateOrganizationsResourceGroupsInviteResponseRole.Contributor => "contributor",
                CreateOrganizationsResourceGroupsInviteResponseRole.NoAccess => "no_access",
                CreateOrganizationsResourceGroupsInviteResponseRole.Read => "read",
                CreateOrganizationsResourceGroupsInviteResponseRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsInviteResponseRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsInviteResponseRole.Admin,
                "contributor" => CreateOrganizationsResourceGroupsInviteResponseRole.Contributor,
                "no_access" => CreateOrganizationsResourceGroupsInviteResponseRole.NoAccess,
                "read" => CreateOrganizationsResourceGroupsInviteResponseRole.Read,
                "write" => CreateOrganizationsResourceGroupsInviteResponseRole.Write,
                _ => null,
            };
        }
    }
}