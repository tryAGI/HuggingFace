
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsUsersRequestUserVariant2Role
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
    public static class CreateOrganizationsResourceGroupsUsersRequestUserVariant2RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsUsersRequestUserVariant2Role value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsUsersRequestUserVariant2Role.Admin => "admin",
                CreateOrganizationsResourceGroupsUsersRequestUserVariant2Role.Contributor => "contributor",
                CreateOrganizationsResourceGroupsUsersRequestUserVariant2Role.NoAccess => "no_access",
                CreateOrganizationsResourceGroupsUsersRequestUserVariant2Role.Read => "read",
                CreateOrganizationsResourceGroupsUsersRequestUserVariant2Role.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsUsersRequestUserVariant2Role? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsUsersRequestUserVariant2Role.Admin,
                "contributor" => CreateOrganizationsResourceGroupsUsersRequestUserVariant2Role.Contributor,
                "no_access" => CreateOrganizationsResourceGroupsUsersRequestUserVariant2Role.NoAccess,
                "read" => CreateOrganizationsResourceGroupsUsersRequestUserVariant2Role.Read,
                "write" => CreateOrganizationsResourceGroupsUsersRequestUserVariant2Role.Write,
                _ => null,
            };
        }
    }
}