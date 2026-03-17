
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOwnerVariant2PrimaryOrgUserRole5
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
    public static class ResponseOwnerVariant2PrimaryOrgUserRole5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOwnerVariant2PrimaryOrgUserRole5 value)
        {
            return value switch
            {
                ResponseOwnerVariant2PrimaryOrgUserRole5.Admin => "admin",
                ResponseOwnerVariant2PrimaryOrgUserRole5.Write => "write",
                ResponseOwnerVariant2PrimaryOrgUserRole5.Contributor => "contributor",
                ResponseOwnerVariant2PrimaryOrgUserRole5.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOwnerVariant2PrimaryOrgUserRole5? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseOwnerVariant2PrimaryOrgUserRole5.Admin,
                "write" => ResponseOwnerVariant2PrimaryOrgUserRole5.Write,
                "contributor" => ResponseOwnerVariant2PrimaryOrgUserRole5.Contributor,
                "read" => ResponseOwnerVariant2PrimaryOrgUserRole5.Read,
                _ => null,
            };
        }
    }
}