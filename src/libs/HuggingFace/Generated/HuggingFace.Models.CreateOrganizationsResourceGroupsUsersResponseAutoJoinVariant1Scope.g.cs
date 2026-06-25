
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope
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
    public static class CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope value)
        {
            return value switch
            {
                CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope.All => "all",
                CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope.ReadPlus => "read_plus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope? ToEnum(string value)
        {
            return value switch
            {
                "all" => CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope.All,
                "read_plus" => CreateOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope.ReadPlus,
                _ => null,
            };
        }
    }
}