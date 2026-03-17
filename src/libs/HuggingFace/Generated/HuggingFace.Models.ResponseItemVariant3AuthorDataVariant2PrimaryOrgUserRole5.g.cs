
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole5
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
    public static class ResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole5 value)
        {
            return value switch
            {
                ResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole5.Admin => "admin",
                ResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole5.Write => "write",
                ResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole5.Contributor => "contributor",
                ResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole5.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole5? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole5.Admin,
                "write" => ResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole5.Write,
                "contributor" => ResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole5.Contributor,
                "read" => ResponseItemVariant3AuthorDataVariant2PrimaryOrgUserRole5.Read,
                _ => null,
            };
        }
    }
}