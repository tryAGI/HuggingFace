
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseUserRole
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
    public static class ResponseUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseUserRole value)
        {
            return value switch
            {
                ResponseUserRole.Admin => "admin",
                ResponseUserRole.Write => "write",
                ResponseUserRole.Contributor => "contributor",
                ResponseUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseUserRole.Admin,
                "write" => ResponseUserRole.Write,
                "contributor" => ResponseUserRole.Contributor,
                "read" => ResponseUserRole.Read,
                _ => null,
            };
        }
    }
}