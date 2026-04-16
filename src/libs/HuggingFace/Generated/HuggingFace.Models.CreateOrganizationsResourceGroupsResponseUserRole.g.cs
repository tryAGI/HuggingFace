
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsResponseUserRole
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
    public static class CreateOrganizationsResourceGroupsResponseUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsResponseUserRole value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsResponseUserRole.Admin => "admin",
                CreateOrganizationsResourceGroupsResponseUserRole.Contributor => "contributor",
                CreateOrganizationsResourceGroupsResponseUserRole.NoAccess => "no_access",
                CreateOrganizationsResourceGroupsResponseUserRole.Read => "read",
                CreateOrganizationsResourceGroupsResponseUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsResponseUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsResponseUserRole.Admin,
                "contributor" => CreateOrganizationsResourceGroupsResponseUserRole.Contributor,
                "no_access" => CreateOrganizationsResourceGroupsResponseUserRole.NoAccess,
                "read" => CreateOrganizationsResourceGroupsResponseUserRole.Read,
                "write" => CreateOrganizationsResourceGroupsResponseUserRole.Write,
                _ => null,
            };
        }
    }
}