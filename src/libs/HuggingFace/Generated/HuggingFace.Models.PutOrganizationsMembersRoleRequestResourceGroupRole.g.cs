
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutOrganizationsMembersRoleRequestResourceGroupRole
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
        NoAccess,
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
    public static class PutOrganizationsMembersRoleRequestResourceGroupRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutOrganizationsMembersRoleRequestResourceGroupRole value)
        {
            return value switch
            {
                PutOrganizationsMembersRoleRequestResourceGroupRole.Admin => "admin",
                PutOrganizationsMembersRoleRequestResourceGroupRole.Contributor => "contributor",
                PutOrganizationsMembersRoleRequestResourceGroupRole.NoAccess => "no_access",
                PutOrganizationsMembersRoleRequestResourceGroupRole.Read => "read",
                PutOrganizationsMembersRoleRequestResourceGroupRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutOrganizationsMembersRoleRequestResourceGroupRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PutOrganizationsMembersRoleRequestResourceGroupRole.Admin,
                "contributor" => PutOrganizationsMembersRoleRequestResourceGroupRole.Contributor,
                "no_access" => PutOrganizationsMembersRoleRequestResourceGroupRole.NoAccess,
                "read" => PutOrganizationsMembersRoleRequestResourceGroupRole.Read,
                "write" => PutOrganizationsMembersRoleRequestResourceGroupRole.Write,
                _ => null,
            };
        }
    }
}