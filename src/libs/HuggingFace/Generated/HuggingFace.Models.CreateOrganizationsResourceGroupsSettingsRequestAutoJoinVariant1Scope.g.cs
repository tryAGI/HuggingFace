
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Scope
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
    public static class CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Scope value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Scope.All => "all",
                CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Scope.ReadPlus => "read_plus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Scope? ToEnum(string value)
        {
            return value switch
            {
                "all" => CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Scope.All,
                "read_plus" => CreateOrganizationsResourceGroupsSettingsRequestAutoJoinVariant1Scope.ReadPlus,
                _ => null,
            };
        }
    }
}