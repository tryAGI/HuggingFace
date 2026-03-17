
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataOwnerVariant2PrimaryOrgUserRole2
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
    public static class ResponseDataOwnerVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataOwnerVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                ResponseDataOwnerVariant2PrimaryOrgUserRole2.Admin => "admin",
                ResponseDataOwnerVariant2PrimaryOrgUserRole2.Write => "write",
                ResponseDataOwnerVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                ResponseDataOwnerVariant2PrimaryOrgUserRole2.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataOwnerVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseDataOwnerVariant2PrimaryOrgUserRole2.Admin,
                "write" => ResponseDataOwnerVariant2PrimaryOrgUserRole2.Write,
                "contributor" => ResponseDataOwnerVariant2PrimaryOrgUserRole2.Contributor,
                "read" => ResponseDataOwnerVariant2PrimaryOrgUserRole2.Read,
                _ => null,
            };
        }
    }
}