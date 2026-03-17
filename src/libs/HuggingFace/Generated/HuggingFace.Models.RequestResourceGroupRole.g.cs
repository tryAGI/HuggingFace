
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestResourceGroupRole
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
    public static class RequestResourceGroupRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestResourceGroupRole value)
        {
            return value switch
            {
                RequestResourceGroupRole.Admin => "admin",
                RequestResourceGroupRole.Write => "write",
                RequestResourceGroupRole.Contributor => "contributor",
                RequestResourceGroupRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestResourceGroupRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => RequestResourceGroupRole.Admin,
                "write" => RequestResourceGroupRole.Write,
                "contributor" => RequestResourceGroupRole.Contributor,
                "read" => RequestResourceGroupRole.Read,
                _ => null,
            };
        }
    }
}