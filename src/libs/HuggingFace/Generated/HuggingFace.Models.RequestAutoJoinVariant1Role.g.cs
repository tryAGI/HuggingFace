
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestAutoJoinVariant1Role
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
    public static class RequestAutoJoinVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestAutoJoinVariant1Role value)
        {
            return value switch
            {
                RequestAutoJoinVariant1Role.Admin => "admin",
                RequestAutoJoinVariant1Role.Write => "write",
                RequestAutoJoinVariant1Role.Contributor => "contributor",
                RequestAutoJoinVariant1Role.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestAutoJoinVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "admin" => RequestAutoJoinVariant1Role.Admin,
                "write" => RequestAutoJoinVariant1Role.Write,
                "contributor" => RequestAutoJoinVariant1Role.Contributor,
                "read" => RequestAutoJoinVariant1Role.Read,
                _ => null,
            };
        }
    }
}