
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemAutoJoinVariant1Role
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
    public static class ResponseItemAutoJoinVariant1RoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemAutoJoinVariant1Role value)
        {
            return value switch
            {
                ResponseItemAutoJoinVariant1Role.Admin => "admin",
                ResponseItemAutoJoinVariant1Role.Write => "write",
                ResponseItemAutoJoinVariant1Role.Contributor => "contributor",
                ResponseItemAutoJoinVariant1Role.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemAutoJoinVariant1Role? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseItemAutoJoinVariant1Role.Admin,
                "write" => ResponseItemAutoJoinVariant1Role.Write,
                "contributor" => ResponseItemAutoJoinVariant1Role.Contributor,
                "read" => ResponseItemAutoJoinVariant1Role.Read,
                _ => null,
            };
        }
    }
}