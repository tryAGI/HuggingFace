
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsResourceGroupsResponseItemUserRole
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
    public static class GetOrganizationsResourceGroupsResponseItemUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsResourceGroupsResponseItemUserRole value)
        {
            return value switch
            {
                GetOrganizationsResourceGroupsResponseItemUserRole.Admin => "admin",
                GetOrganizationsResourceGroupsResponseItemUserRole.Contributor => "contributor",
                GetOrganizationsResourceGroupsResponseItemUserRole.Read => "read",
                GetOrganizationsResourceGroupsResponseItemUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsResourceGroupsResponseItemUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetOrganizationsResourceGroupsResponseItemUserRole.Admin,
                "contributor" => GetOrganizationsResourceGroupsResponseItemUserRole.Contributor,
                "read" => GetOrganizationsResourceGroupsResponseItemUserRole.Read,
                "write" => GetOrganizationsResourceGroupsResponseItemUserRole.Write,
                _ => null,
            };
        }
    }
}