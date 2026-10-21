
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Minimum organization role required to create a resource group
    /// </summary>
    public enum CreateOrganizationsResourceGroupsSettingsRequestMinRoleToCreate
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
    public static class CreateOrganizationsResourceGroupsSettingsRequestMinRoleToCreateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsSettingsRequestMinRoleToCreate value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsSettingsRequestMinRoleToCreate.Admin => "admin",
                CreateOrganizationsResourceGroupsSettingsRequestMinRoleToCreate.Contributor => "contributor",
                CreateOrganizationsResourceGroupsSettingsRequestMinRoleToCreate.Read => "read",
                CreateOrganizationsResourceGroupsSettingsRequestMinRoleToCreate.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsSettingsRequestMinRoleToCreate? ToEnum(string value)
        {
            return value switch
            {
                "admin" => CreateOrganizationsResourceGroupsSettingsRequestMinRoleToCreate.Admin,
                "contributor" => CreateOrganizationsResourceGroupsSettingsRequestMinRoleToCreate.Contributor,
                "read" => CreateOrganizationsResourceGroupsSettingsRequestMinRoleToCreate.Read,
                "write" => CreateOrganizationsResourceGroupsSettingsRequestMinRoleToCreate.Write,
                _ => null,
            };
        }
    }
}