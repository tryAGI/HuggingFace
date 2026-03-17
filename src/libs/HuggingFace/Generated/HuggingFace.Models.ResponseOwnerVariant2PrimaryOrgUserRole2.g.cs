
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOwnerVariant2PrimaryOrgUserRole2
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
    public static class ResponseOwnerVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOwnerVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                ResponseOwnerVariant2PrimaryOrgUserRole2.Admin => "admin",
                ResponseOwnerVariant2PrimaryOrgUserRole2.Write => "write",
                ResponseOwnerVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                ResponseOwnerVariant2PrimaryOrgUserRole2.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOwnerVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseOwnerVariant2PrimaryOrgUserRole2.Admin,
                "write" => ResponseOwnerVariant2PrimaryOrgUserRole2.Write,
                "contributor" => ResponseOwnerVariant2PrimaryOrgUserRole2.Contributor,
                "read" => ResponseOwnerVariant2PrimaryOrgUserRole2.Read,
                _ => null,
            };
        }
    }
}