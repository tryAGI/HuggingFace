
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Scope
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
    public static class PatchOrganizationsResourceGroupsResponseAutoJoinVariant1ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Scope value)
        {
            return value switch
            {
                PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Scope.All => "all",
                PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Scope.ReadPlus => "read_plus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Scope? ToEnum(string value)
        {
            return value switch
            {
                "all" => PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Scope.All,
                "read_plus" => PatchOrganizationsResourceGroupsResponseAutoJoinVariant1Scope.ReadPlus,
                _ => null,
            };
        }
    }
}