
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Role
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
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Role value)
        {
            return value switch
            {
                GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Role.Admin => "admin",
                GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Role.Contributor => "contributor",
                GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Role.Read => "read",
                GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Role.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Role.Admin,
                "contributor" => GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Role.Contributor,
                "read" => GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Role.Read,
                "write" => GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Role.Write,
                _ => null,
            };
        }
    }
}