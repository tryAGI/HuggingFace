
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOrgResourceGroupRole
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
    public static class ResponseOrgResourceGroupRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOrgResourceGroupRole value)
        {
            return value switch
            {
                ResponseOrgResourceGroupRole.Admin => "admin",
                ResponseOrgResourceGroupRole.Write => "write",
                ResponseOrgResourceGroupRole.Contributor => "contributor",
                ResponseOrgResourceGroupRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOrgResourceGroupRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseOrgResourceGroupRole.Admin,
                "write" => ResponseOrgResourceGroupRole.Write,
                "contributor" => ResponseOrgResourceGroupRole.Contributor,
                "read" => ResponseOrgResourceGroupRole.Read,
                _ => null,
            };
        }
    }
}