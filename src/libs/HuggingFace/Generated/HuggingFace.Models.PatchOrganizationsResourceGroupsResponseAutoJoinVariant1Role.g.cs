
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role
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
    public static class PatchOrganizationsResourceGroupsResponseAutoJoinVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role value)
        {
            return value switch
            {
                PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Admin => "admin",
                PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Contributor => "contributor",
                PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role.NoAccess => "no_access",
                PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Read => "read",
                PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Admin,
                "contributor" => PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Contributor,
                "no_access" => PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role.NoAccess,
                "read" => PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Read,
                "write" => PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Role.Write,
                _ => null,
            };
        }
    }
}