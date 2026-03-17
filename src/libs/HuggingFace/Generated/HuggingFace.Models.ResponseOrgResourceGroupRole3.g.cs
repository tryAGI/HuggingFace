
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOrgResourceGroupRole3
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
    public static class ResponseOrgResourceGroupRole3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOrgResourceGroupRole3 value)
        {
            return value switch
            {
                ResponseOrgResourceGroupRole3.Admin => "admin",
                ResponseOrgResourceGroupRole3.Write => "write",
                ResponseOrgResourceGroupRole3.Contributor => "contributor",
                ResponseOrgResourceGroupRole3.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOrgResourceGroupRole3? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseOrgResourceGroupRole3.Admin,
                "write" => ResponseOrgResourceGroupRole3.Write,
                "contributor" => ResponseOrgResourceGroupRole3.Contributor,
                "read" => ResponseOrgResourceGroupRole3.Read,
                _ => null,
            };
        }
    }
}