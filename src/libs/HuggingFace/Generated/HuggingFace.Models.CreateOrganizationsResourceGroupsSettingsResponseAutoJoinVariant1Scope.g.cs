
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Scope
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        ReadPlus,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Scope value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Scope.All => "all",
                CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Scope.ReadPlus => "read_plus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Scope? ToEnum(string value)
        {
            return value switch
            {
                "all" => CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Scope.All,
                "read_plus" => CreateOrganizationsResourceGroupsSettingsResponseAutoJoinVariant1Scope.ReadPlus,
                _ => null,
            };
        }
    }
}