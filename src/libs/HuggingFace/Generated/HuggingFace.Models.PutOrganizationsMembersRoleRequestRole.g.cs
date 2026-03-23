
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutOrganizationsMembersRoleRequestRole
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
    public static class PutOrganizationsMembersRoleRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutOrganizationsMembersRoleRequestRole value)
        {
            return value switch
            {
                PutOrganizationsMembersRoleRequestRole.Admin => "admin",
                PutOrganizationsMembersRoleRequestRole.Contributor => "contributor",
                PutOrganizationsMembersRoleRequestRole.Read => "read",
                PutOrganizationsMembersRoleRequestRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutOrganizationsMembersRoleRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => PutOrganizationsMembersRoleRequestRole.Admin,
                "contributor" => PutOrganizationsMembersRoleRequestRole.Contributor,
                "read" => PutOrganizationsMembersRoleRequestRole.Read,
                "write" => PutOrganizationsMembersRoleRequestRole.Write,
                _ => null,
            };
        }
    }
}