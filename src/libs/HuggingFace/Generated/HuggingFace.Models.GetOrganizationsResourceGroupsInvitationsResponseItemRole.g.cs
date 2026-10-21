
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Organization role the invitee joins with
    /// </summary>
    public enum GetOrganizationsResourceGroupsInvitationsResponseItemRole
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
    public static class GetOrganizationsResourceGroupsInvitationsResponseItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsResourceGroupsInvitationsResponseItemRole value)
        {
            return value switch
            {
                GetOrganizationsResourceGroupsInvitationsResponseItemRole.Admin => "admin",
                GetOrganizationsResourceGroupsInvitationsResponseItemRole.Contributor => "contributor",
                GetOrganizationsResourceGroupsInvitationsResponseItemRole.NoAccess => "no_access",
                GetOrganizationsResourceGroupsInvitationsResponseItemRole.Read => "read",
                GetOrganizationsResourceGroupsInvitationsResponseItemRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsResourceGroupsInvitationsResponseItemRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetOrganizationsResourceGroupsInvitationsResponseItemRole.Admin,
                "contributor" => GetOrganizationsResourceGroupsInvitationsResponseItemRole.Contributor,
                "no_access" => GetOrganizationsResourceGroupsInvitationsResponseItemRole.NoAccess,
                "read" => GetOrganizationsResourceGroupsInvitationsResponseItemRole.Read,
                "write" => GetOrganizationsResourceGroupsInvitationsResponseItemRole.Write,
                _ => null,
            };
        }
    }
}