
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsMembersResponseItemResourceGroupRole
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
    public static class GetOrganizationsMembersResponseItemResourceGroupRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsMembersResponseItemResourceGroupRole value)
        {
            return value switch
            {
                GetOrganizationsMembersResponseItemResourceGroupRole.Admin => "admin",
                GetOrganizationsMembersResponseItemResourceGroupRole.Contributor => "contributor",
                GetOrganizationsMembersResponseItemResourceGroupRole.NoAccess => "no_access",
                GetOrganizationsMembersResponseItemResourceGroupRole.Read => "read",
                GetOrganizationsMembersResponseItemResourceGroupRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsMembersResponseItemResourceGroupRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetOrganizationsMembersResponseItemResourceGroupRole.Admin,
                "contributor" => GetOrganizationsMembersResponseItemResourceGroupRole.Contributor,
                "no_access" => GetOrganizationsMembersResponseItemResourceGroupRole.NoAccess,
                "read" => GetOrganizationsMembersResponseItemResourceGroupRole.Read,
                "write" => GetOrganizationsMembersResponseItemResourceGroupRole.Write,
                _ => null,
            };
        }
    }
}