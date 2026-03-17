
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOrgRoleInOrg2
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
    public static class ResponseOrgRoleInOrg2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOrgRoleInOrg2 value)
        {
            return value switch
            {
                ResponseOrgRoleInOrg2.Admin => "admin",
                ResponseOrgRoleInOrg2.Write => "write",
                ResponseOrgRoleInOrg2.Contributor => "contributor",
                ResponseOrgRoleInOrg2.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOrgRoleInOrg2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseOrgRoleInOrg2.Admin,
                "write" => ResponseOrgRoleInOrg2.Write,
                "contributor" => ResponseOrgRoleInOrg2.Contributor,
                "read" => ResponseOrgRoleInOrg2.Read,
                _ => null,
            };
        }
    }
}