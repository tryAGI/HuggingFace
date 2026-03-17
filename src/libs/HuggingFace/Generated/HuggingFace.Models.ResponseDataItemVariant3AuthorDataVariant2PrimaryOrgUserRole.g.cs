
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole
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
    public static class ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Write => "write",
                ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseDataItemVariant3AuthorDataVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}