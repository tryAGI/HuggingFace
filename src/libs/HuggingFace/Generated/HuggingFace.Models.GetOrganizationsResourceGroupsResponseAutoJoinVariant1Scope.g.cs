
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsResourceGroupsResponseAutoJoinVariant1Scope
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
    public static class GetOrganizationsResourceGroupsResponseAutoJoinVariant1ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsResourceGroupsResponseAutoJoinVariant1Scope value)
        {
            return value switch
            {
                GetOrganizationsResourceGroupsResponseAutoJoinVariant1Scope.All => "all",
                GetOrganizationsResourceGroupsResponseAutoJoinVariant1Scope.ReadPlus => "read_plus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsResourceGroupsResponseAutoJoinVariant1Scope? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetOrganizationsResourceGroupsResponseAutoJoinVariant1Scope.All,
                "read_plus" => GetOrganizationsResourceGroupsResponseAutoJoinVariant1Scope.ReadPlus,
                _ => null,
            };
        }
    }
}