
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationsResourceGroupsInvitationsResponseItemResourceGroupRole
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
    public static class GetOrganizationsResourceGroupsInvitationsResponseItemResourceGroupRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsResourceGroupsInvitationsResponseItemResourceGroupRole value)
        {
            return value switch
            {
                GetOrganizationsResourceGroupsInvitationsResponseItemResourceGroupRole.Read => "read",
                GetOrganizationsResourceGroupsInvitationsResponseItemResourceGroupRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsResourceGroupsInvitationsResponseItemResourceGroupRole? ToEnum(string value)
        {
            return value switch
            {
                "read" => GetOrganizationsResourceGroupsInvitationsResponseItemResourceGroupRole.Read,
                "write" => GetOrganizationsResourceGroupsInvitationsResponseItemResourceGroupRole.Write,
                _ => null,
            };
        }
    }
}