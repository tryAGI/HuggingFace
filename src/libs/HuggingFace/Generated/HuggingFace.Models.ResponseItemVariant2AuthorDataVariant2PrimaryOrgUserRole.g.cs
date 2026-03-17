
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole
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
    public static class ResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Write => "write",
                ResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseItemVariant2AuthorDataVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}