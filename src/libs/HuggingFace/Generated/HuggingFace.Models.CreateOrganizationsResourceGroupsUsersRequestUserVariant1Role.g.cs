
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsUsersRequestUserVariant1Role
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
    public static class CreateOrganizationsResourceGroupsUsersRequestUserVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsUsersRequestUserVariant1Role value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsUsersRequestUserVariant1Role.Admin => "admin",
                CreateOrganizationsResourceGroupsUsersRequestUserVariant1Role.Contributor => "contributor",
                CreateOrganizationsResourceGroupsUsersRequestUserVariant1Role.NoAccess => "no_access",
                CreateOrganizationsResourceGroupsUsersRequestUserVariant1Role.Read => "read",
                CreateOrganizationsResourceGroupsUsersRequestUserVariant1Role.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsUsersRequestUserVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsUsersRequestUserVariant1Role.Admin,
                "contributor" => CreateOrganizationsResourceGroupsUsersRequestUserVariant1Role.Contributor,
                "no_access" => CreateOrganizationsResourceGroupsUsersRequestUserVariant1Role.NoAccess,
                "read" => CreateOrganizationsResourceGroupsUsersRequestUserVariant1Role.Read,
                "write" => CreateOrganizationsResourceGroupsUsersRequestUserVariant1Role.Write,
                _ => null,
            };
        }
    }
}