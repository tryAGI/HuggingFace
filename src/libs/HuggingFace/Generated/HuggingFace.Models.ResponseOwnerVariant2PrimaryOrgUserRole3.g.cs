
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOwnerVariant2PrimaryOrgUserRole3
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
    public static class ResponseOwnerVariant2PrimaryOrgUserRole3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOwnerVariant2PrimaryOrgUserRole3 value)
        {
            return value switch
            {
                ResponseOwnerVariant2PrimaryOrgUserRole3.Admin => "admin",
                ResponseOwnerVariant2PrimaryOrgUserRole3.Write => "write",
                ResponseOwnerVariant2PrimaryOrgUserRole3.Contributor => "contributor",
                ResponseOwnerVariant2PrimaryOrgUserRole3.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOwnerVariant2PrimaryOrgUserRole3? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseOwnerVariant2PrimaryOrgUserRole3.Admin,
                "write" => ResponseOwnerVariant2PrimaryOrgUserRole3.Write,
                "contributor" => ResponseOwnerVariant2PrimaryOrgUserRole3.Contributor,
                "read" => ResponseOwnerVariant2PrimaryOrgUserRole3.Read,
                _ => null,
            };
        }
    }
}