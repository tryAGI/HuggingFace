
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsResourceGroupsResponseAutoJoinVariant1Role
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
    public static class GetOrganizationsResourceGroupsResponseAutoJoinVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsResourceGroupsResponseAutoJoinVariant1Role value)
        {
            return value switch
            {
                GetOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Admin => "admin",
                GetOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Contributor => "contributor",
                GetOrganizationsResourceGroupsResponseAutoJoinVariant1Role.NoAccess => "no_access",
                GetOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Read => "read",
                GetOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsResourceGroupsResponseAutoJoinVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Admin,
                "contributor" => GetOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Contributor,
                "no_access" => GetOrganizationsResourceGroupsResponseAutoJoinVariant1Role.NoAccess,
                "read" => GetOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Read,
                "write" => GetOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Write,
                _ => null,
            };
        }
    }
}