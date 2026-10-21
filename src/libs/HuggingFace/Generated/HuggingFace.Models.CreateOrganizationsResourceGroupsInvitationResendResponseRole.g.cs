
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Organization role the invitee joins with
    /// </summary>
    public enum CreateOrganizationsResourceGroupsInvitationResendResponseRole
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
    public static class CreateOrganizationsResourceGroupsInvitationResendResponseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsInvitationResendResponseRole value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsInvitationResendResponseRole.Admin => "admin",
                CreateOrganizationsResourceGroupsInvitationResendResponseRole.Contributor => "contributor",
                CreateOrganizationsResourceGroupsInvitationResendResponseRole.NoAccess => "no_access",
                CreateOrganizationsResourceGroupsInvitationResendResponseRole.Read => "read",
                CreateOrganizationsResourceGroupsInvitationResendResponseRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsInvitationResendResponseRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsInvitationResendResponseRole.Admin,
                "contributor" => CreateOrganizationsResourceGroupsInvitationResendResponseRole.Contributor,
                "no_access" => CreateOrganizationsResourceGroupsInvitationResendResponseRole.NoAccess,
                "read" => CreateOrganizationsResourceGroupsInvitationResendResponseRole.Read,
                "write" => CreateOrganizationsResourceGroupsInvitationResendResponseRole.Write,
                _ => null,
            };
        }
    }
}