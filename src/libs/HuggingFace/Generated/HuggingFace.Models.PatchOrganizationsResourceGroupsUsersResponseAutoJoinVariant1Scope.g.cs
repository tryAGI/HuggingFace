
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope
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
    public static class PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope value)
        {
            return value switch
            {
                PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope.All => "all",
                PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope.ReadPlus => "read_plus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope? ToEnum(string value)
        {
            return value switch
            {
                "all" => PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope.All,
                "read_plus" => PatchOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope.ReadPlus,
                _ => null,
            };
        }
    }
}