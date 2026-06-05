
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Scope
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Scope value)
        {
            return value switch
            {
                GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Scope.All => "all",
                GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Scope.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Scope? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Scope.All,
                "internal" => GetOrganizationsResourceGroupsResponseItemAutoJoinVariant1Scope.Internal,
                _ => null,
            };
        }
    }
}