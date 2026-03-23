
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Role
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
    public static class CreateOrganizationsResourceGroupsRequestAutoJoinVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Role value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Role.Admin => "admin",
                CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Role.Contributor => "contributor",
                CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Role.Read => "read",
                CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Role.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Role.Admin,
                "contributor" => CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Role.Contributor,
                "read" => CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Role.Read,
                "write" => CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Role.Write,
                _ => null,
            };
        }
    }
}