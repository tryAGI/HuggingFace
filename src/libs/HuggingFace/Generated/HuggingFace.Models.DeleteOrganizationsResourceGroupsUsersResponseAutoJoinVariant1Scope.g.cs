
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope
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
    public static class DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1ScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope value)
        {
            return value switch
            {
                DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope.All => "all",
                DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope.ReadPlus => "read_plus",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope? ToEnum(string value)
        {
            return value switch
            {
                "all" => DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope.All,
                "read_plus" => DeleteOrganizationsResourceGroupsUsersResponseAutoJoinVariant1Scope.ReadPlus,
                _ => null,
            };
        }
    }
}