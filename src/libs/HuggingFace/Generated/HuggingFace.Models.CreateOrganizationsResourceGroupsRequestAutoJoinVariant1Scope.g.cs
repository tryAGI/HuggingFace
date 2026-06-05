
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Scope
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
    public static class CreateOrganizationsResourceGroupsRequestAutoJoinVariant1ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Scope value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Scope.All => "all",
                CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Scope.Internal => "internal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Scope? ToEnum(string value)
        {
            return value switch
            {
                "all" => CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Scope.All,
                "internal" => CreateOrganizationsResourceGroupsRequestAutoJoinVariant1Scope.Internal,
                _ => null,
            };
        }
    }
}