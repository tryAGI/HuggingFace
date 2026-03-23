
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetOrganizationsMembersResponseItemRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Contributor,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrganizationsMembersResponseItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrganizationsMembersResponseItemRole value)
        {
            return value switch
            {
                GetOrganizationsMembersResponseItemRole.Admin => "admin",
                GetOrganizationsMembersResponseItemRole.Contributor => "contributor",
                GetOrganizationsMembersResponseItemRole.Read => "read",
                GetOrganizationsMembersResponseItemRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrganizationsMembersResponseItemRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetOrganizationsMembersResponseItemRole.Admin,
                "contributor" => GetOrganizationsMembersResponseItemRole.Contributor,
                "read" => GetOrganizationsMembersResponseItemRole.Read,
                "write" => GetOrganizationsMembersResponseItemRole.Write,
                _ => null,
            };
        }
    }
}