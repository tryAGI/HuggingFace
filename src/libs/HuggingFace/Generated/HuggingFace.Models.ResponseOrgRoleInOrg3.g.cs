
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOrgRoleInOrg3
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
    public static class ResponseOrgRoleInOrg3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOrgRoleInOrg3 value)
        {
            return value switch
            {
                ResponseOrgRoleInOrg3.Admin => "admin",
                ResponseOrgRoleInOrg3.Write => "write",
                ResponseOrgRoleInOrg3.Contributor => "contributor",
                ResponseOrgRoleInOrg3.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOrgRoleInOrg3? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseOrgRoleInOrg3.Admin,
                "write" => ResponseOrgRoleInOrg3.Write,
                "contributor" => ResponseOrgRoleInOrg3.Contributor,
                "read" => ResponseOrgRoleInOrg3.Read,
                _ => null,
            };
        }
    }
}