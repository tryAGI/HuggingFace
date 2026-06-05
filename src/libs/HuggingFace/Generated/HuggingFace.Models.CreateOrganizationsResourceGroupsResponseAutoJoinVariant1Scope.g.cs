
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Scope
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
    public static class CreateOrganizationsResourceGroupsResponseAutoJoinVariant1ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Scope value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Scope.All => "all",
                CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Scope.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Scope? ToEnum(string value)
        {
            return value switch
            {
                "all" => CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Scope.All,
                "internal" => CreateOrganizationsResourceGroupsResponseAutoJoinVariant1Scope.Internal,
                _ => null,
            };
        }
    }
}