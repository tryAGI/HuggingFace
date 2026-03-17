
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOrgRoleInOrg
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Write,
        /// <summary>
        /// 
        /// </summary>
        Contributor,
        /// <summary>
        /// 
        /// </summary>
        Read,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseOrgRoleInOrgExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOrgRoleInOrg value)
        {
            return value switch
            {
                ResponseOrgRoleInOrg.Admin => "admin",
                ResponseOrgRoleInOrg.Write => "write",
                ResponseOrgRoleInOrg.Contributor => "contributor",
                ResponseOrgRoleInOrg.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOrgRoleInOrg? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseOrgRoleInOrg.Admin,
                "write" => ResponseOrgRoleInOrg.Write,
                "contributor" => ResponseOrgRoleInOrg.Contributor,
                "read" => ResponseOrgRoleInOrg.Read,
                _ => null,
            };
        }
    }
}