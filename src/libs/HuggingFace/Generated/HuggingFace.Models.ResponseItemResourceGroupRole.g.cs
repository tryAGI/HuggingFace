
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemResourceGroupRole
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
    public static class ResponseItemResourceGroupRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemResourceGroupRole value)
        {
            return value switch
            {
                ResponseItemResourceGroupRole.Admin => "admin",
                ResponseItemResourceGroupRole.Write => "write",
                ResponseItemResourceGroupRole.Contributor => "contributor",
                ResponseItemResourceGroupRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemResourceGroupRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseItemResourceGroupRole.Admin,
                "write" => ResponseItemResourceGroupRole.Write,
                "contributor" => ResponseItemResourceGroupRole.Contributor,
                "read" => ResponseItemResourceGroupRole.Read,
                _ => null,
            };
        }
    }
}