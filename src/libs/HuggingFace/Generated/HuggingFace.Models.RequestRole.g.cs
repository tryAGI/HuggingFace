
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestRole
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
    public static class RequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestRole value)
        {
            return value switch
            {
                RequestRole.Admin => "admin",
                RequestRole.Write => "write",
                RequestRole.Contributor => "contributor",
                RequestRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => RequestRole.Admin,
                "write" => RequestRole.Write,
                "contributor" => RequestRole.Contributor,
                "read" => RequestRole.Read,
                _ => null,
            };
        }
    }
}