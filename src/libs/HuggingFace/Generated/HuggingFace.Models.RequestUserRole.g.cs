
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestUserRole
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
    public static class RequestUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestUserRole value)
        {
            return value switch
            {
                RequestUserRole.Admin => "admin",
                RequestUserRole.Write => "write",
                RequestUserRole.Contributor => "contributor",
                RequestUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => RequestUserRole.Admin,
                "write" => RequestUserRole.Write,
                "contributor" => RequestUserRole.Contributor,
                "read" => RequestUserRole.Read,
                _ => null,
            };
        }
    }
}