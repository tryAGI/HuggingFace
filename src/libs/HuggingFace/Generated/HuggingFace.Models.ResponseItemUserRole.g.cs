
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemUserRole
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
    public static class ResponseItemUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemUserRole value)
        {
            return value switch
            {
                ResponseItemUserRole.Admin => "admin",
                ResponseItemUserRole.Write => "write",
                ResponseItemUserRole.Contributor => "contributor",
                ResponseItemUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseItemUserRole.Admin,
                "write" => ResponseItemUserRole.Write,
                "contributor" => ResponseItemUserRole.Contributor,
                "read" => ResponseItemUserRole.Read,
                _ => null,
            };
        }
    }
}