
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseAutoJoinVariant1Role
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
    public static class ResponseAutoJoinVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAutoJoinVariant1Role value)
        {
            return value switch
            {
                ResponseAutoJoinVariant1Role.Admin => "admin",
                ResponseAutoJoinVariant1Role.Write => "write",
                ResponseAutoJoinVariant1Role.Contributor => "contributor",
                ResponseAutoJoinVariant1Role.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAutoJoinVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseAutoJoinVariant1Role.Admin,
                "write" => ResponseAutoJoinVariant1Role.Write,
                "contributor" => ResponseAutoJoinVariant1Role.Contributor,
                "read" => ResponseAutoJoinVariant1Role.Read,
                _ => null,
            };
        }
    }
}