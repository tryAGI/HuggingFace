
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsRequestUserRole
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
    public static class CreateOrganizationsResourceGroupsRequestUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsRequestUserRole value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsRequestUserRole.Admin => "admin",
                CreateOrganizationsResourceGroupsRequestUserRole.Contributor => "contributor",
                CreateOrganizationsResourceGroupsRequestUserRole.NoAccess => "no_access",
                CreateOrganizationsResourceGroupsRequestUserRole.Read => "read",
                CreateOrganizationsResourceGroupsRequestUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsRequestUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsRequestUserRole.Admin,
                "contributor" => CreateOrganizationsResourceGroupsRequestUserRole.Contributor,
                "no_access" => CreateOrganizationsResourceGroupsRequestUserRole.NoAccess,
                "read" => CreateOrganizationsResourceGroupsRequestUserRole.Read,
                "write" => CreateOrganizationsResourceGroupsRequestUserRole.Write,
                _ => null,
            };
        }
    }
}