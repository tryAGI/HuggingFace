
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateOrganizationsResourceGroupsInvitationResendResponseResourceGroupRole
    {
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
    public static class CreateOrganizationsResourceGroupsInvitationResendResponseResourceGroupRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsInvitationResendResponseResourceGroupRole value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsInvitationResendResponseResourceGroupRole.Read => "read",
                CreateOrganizationsResourceGroupsInvitationResendResponseResourceGroupRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsInvitationResendResponseResourceGroupRole? ToEnum(string value)
        {
            return value switch
            {
                "read" => CreateOrganizationsResourceGroupsInvitationResendResponseResourceGroupRole.Read,
                "write" => CreateOrganizationsResourceGroupsInvitationResendResponseResourceGroupRole.Write,
                _ => null,
            };
        }
    }
}