
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Role the invitee gets inside the resource group
    /// </summary>
    public enum CreateOrganizationsResourceGroupsInviteRequestRole
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
    public static class CreateOrganizationsResourceGroupsInviteRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsInviteRequestRole value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsInviteRequestRole.Read => "read",
                CreateOrganizationsResourceGroupsInviteRequestRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsInviteRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "read" => CreateOrganizationsResourceGroupsInviteRequestRole.Read,
                "write" => CreateOrganizationsResourceGroupsInviteRequestRole.Write,
                _ => null,
            };
        }
    }
}