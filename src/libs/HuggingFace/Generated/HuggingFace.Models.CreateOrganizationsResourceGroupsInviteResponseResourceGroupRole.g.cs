
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateOrganizationsResourceGroupsInviteResponseResourceGroupRole
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
    public static class CreateOrganizationsResourceGroupsInviteResponseResourceGroupRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsInviteResponseResourceGroupRole value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsInviteResponseResourceGroupRole.Read => "read",
                CreateOrganizationsResourceGroupsInviteResponseResourceGroupRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsInviteResponseResourceGroupRole? ToEnum(string value)
        {
            return value switch
            {
                "read" => CreateOrganizationsResourceGroupsInviteResponseResourceGroupRole.Read,
                "write" => CreateOrganizationsResourceGroupsInviteResponseResourceGroupRole.Write,
                _ => null,
            };
        }
    }
}