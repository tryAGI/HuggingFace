
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOrgResourceGroupRole2
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
    public static class ResponseOrgResourceGroupRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOrgResourceGroupRole2 value)
        {
            return value switch
            {
                ResponseOrgResourceGroupRole2.Admin => "admin",
                ResponseOrgResourceGroupRole2.Write => "write",
                ResponseOrgResourceGroupRole2.Contributor => "contributor",
                ResponseOrgResourceGroupRole2.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOrgResourceGroupRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseOrgResourceGroupRole2.Admin,
                "write" => ResponseOrgResourceGroupRole2.Write,
                "contributor" => ResponseOrgResourceGroupRole2.Contributor,
                "read" => ResponseOrgResourceGroupRole2.Read,
                _ => null,
            };
        }
    }
}