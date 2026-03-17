
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant5OwnerVariant2PrimaryOrgUserRole5
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
    public static class ResponseItemVariant5OwnerVariant2PrimaryOrgUserRole5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant5OwnerVariant2PrimaryOrgUserRole5 value)
        {
            return value switch
            {
                ResponseItemVariant5OwnerVariant2PrimaryOrgUserRole5.Admin => "admin",
                ResponseItemVariant5OwnerVariant2PrimaryOrgUserRole5.Write => "write",
                ResponseItemVariant5OwnerVariant2PrimaryOrgUserRole5.Contributor => "contributor",
                ResponseItemVariant5OwnerVariant2PrimaryOrgUserRole5.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant5OwnerVariant2PrimaryOrgUserRole5? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseItemVariant5OwnerVariant2PrimaryOrgUserRole5.Admin,
                "write" => ResponseItemVariant5OwnerVariant2PrimaryOrgUserRole5.Write,
                "contributor" => ResponseItemVariant5OwnerVariant2PrimaryOrgUserRole5.Contributor,
                "read" => ResponseItemVariant5OwnerVariant2PrimaryOrgUserRole5.Read,
                _ => null,
            };
        }
    }
}