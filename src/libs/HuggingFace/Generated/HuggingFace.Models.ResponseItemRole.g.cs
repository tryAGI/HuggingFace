
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemRole
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
    public static class ResponseItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemRole value)
        {
            return value switch
            {
                ResponseItemRole.Admin => "admin",
                ResponseItemRole.Write => "write",
                ResponseItemRole.Contributor => "contributor",
                ResponseItemRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseItemRole.Admin,
                "write" => ResponseItemRole.Write,
                "contributor" => ResponseItemRole.Contributor,
                "read" => ResponseItemRole.Read,
                _ => null,
            };
        }
    }
}