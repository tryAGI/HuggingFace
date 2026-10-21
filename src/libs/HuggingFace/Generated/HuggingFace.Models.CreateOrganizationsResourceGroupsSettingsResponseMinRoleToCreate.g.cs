
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateOrganizationsResourceGroupsSettingsResponseMinRoleToCreate
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
    public static class CreateOrganizationsResourceGroupsSettingsResponseMinRoleToCreateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsSettingsResponseMinRoleToCreate value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsSettingsResponseMinRoleToCreate.Admin => "admin",
                CreateOrganizationsResourceGroupsSettingsResponseMinRoleToCreate.Contributor => "contributor",
                CreateOrganizationsResourceGroupsSettingsResponseMinRoleToCreate.Read => "read",
                CreateOrganizationsResourceGroupsSettingsResponseMinRoleToCreate.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsSettingsResponseMinRoleToCreate? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsSettingsResponseMinRoleToCreate.Admin,
                "contributor" => CreateOrganizationsResourceGroupsSettingsResponseMinRoleToCreate.Contributor,
                "read" => CreateOrganizationsResourceGroupsSettingsResponseMinRoleToCreate.Read,
                "write" => CreateOrganizationsResourceGroupsSettingsResponseMinRoleToCreate.Write,
                _ => null,
            };
        }
    }
}