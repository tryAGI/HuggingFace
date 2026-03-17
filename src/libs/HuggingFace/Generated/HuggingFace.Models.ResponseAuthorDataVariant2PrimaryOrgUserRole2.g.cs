
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseAuthorDataVariant2PrimaryOrgUserRole2
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
    public static class ResponseAuthorDataVariant2PrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAuthorDataVariant2PrimaryOrgUserRole2 value)
        {
            return value switch
            {
                ResponseAuthorDataVariant2PrimaryOrgUserRole2.Admin => "admin",
                ResponseAuthorDataVariant2PrimaryOrgUserRole2.Write => "write",
                ResponseAuthorDataVariant2PrimaryOrgUserRole2.Contributor => "contributor",
                ResponseAuthorDataVariant2PrimaryOrgUserRole2.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAuthorDataVariant2PrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseAuthorDataVariant2PrimaryOrgUserRole2.Admin,
                "write" => ResponseAuthorDataVariant2PrimaryOrgUserRole2.Write,
                "contributor" => ResponseAuthorDataVariant2PrimaryOrgUserRole2.Contributor,
                "read" => ResponseAuthorDataVariant2PrimaryOrgUserRole2.Read,
                _ => null,
            };
        }
    }
}