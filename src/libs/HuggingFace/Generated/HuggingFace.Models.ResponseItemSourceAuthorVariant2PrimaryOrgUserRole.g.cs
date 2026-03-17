
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSourceAuthorVariant2PrimaryOrgUserRole
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
    public static class ResponseItemSourceAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSourceAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseItemSourceAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseItemSourceAuthorVariant2PrimaryOrgUserRole.Write => "write",
                ResponseItemSourceAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseItemSourceAuthorVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSourceAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseItemSourceAuthorVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseItemSourceAuthorVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseItemSourceAuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseItemSourceAuthorVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}