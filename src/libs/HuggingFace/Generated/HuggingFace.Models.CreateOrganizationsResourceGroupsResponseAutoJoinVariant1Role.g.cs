
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Role
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
    public static class CreateOrganizationsResourceGroupsResponseAutoJoinVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Role value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Admin => "admin",
                CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Contributor => "contributor",
                CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Read => "read",
                CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Admin,
                "contributor" => CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Contributor,
                "read" => CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Read,
                "write" => CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Write,
                _ => null,
            };
        }
    }
}