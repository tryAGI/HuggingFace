
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum GetOrganizationsResourceGroupsSettingsResponseMinRoleToCreate
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
    public static class GetOrganizationsResourceGroupsSettingsResponseMinRoleToCreateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsResourceGroupsSettingsResponseMinRoleToCreate value)
        {
            return value switch
            {
                GetOrganizationsResourceGroupsSettingsResponseMinRoleToCreate.Admin => "admin",
                GetOrganizationsResourceGroupsSettingsResponseMinRoleToCreate.Contributor => "contributor",
                GetOrganizationsResourceGroupsSettingsResponseMinRoleToCreate.Read => "read",
                GetOrganizationsResourceGroupsSettingsResponseMinRoleToCreate.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsResourceGroupsSettingsResponseMinRoleToCreate? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetOrganizationsResourceGroupsSettingsResponseMinRoleToCreate.Admin,
                "contributor" => GetOrganizationsResourceGroupsSettingsResponseMinRoleToCreate.Contributor,
                "read" => GetOrganizationsResourceGroupsSettingsResponseMinRoleToCreate.Read,
                "write" => GetOrganizationsResourceGroupsSettingsResponseMinRoleToCreate.Write,
                _ => null,
            };
        }
    }
}