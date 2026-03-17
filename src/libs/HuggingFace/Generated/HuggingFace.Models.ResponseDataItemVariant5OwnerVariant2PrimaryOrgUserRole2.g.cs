
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2
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
    public static class ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2.Admin => "admin",
                ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2.Write => "write",
                ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2.Admin,
                "write" => ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2.Write,
                "contributor" => ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2.Contributor,
                "read" => ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole2.Read,
                _ => null,
            };
        }
    }
}