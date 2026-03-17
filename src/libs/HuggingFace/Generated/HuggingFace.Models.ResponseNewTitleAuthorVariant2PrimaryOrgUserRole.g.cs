
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewTitleAuthorVariant2PrimaryOrgUserRole
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
    public static class ResponseNewTitleAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewTitleAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseNewTitleAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseNewTitleAuthorVariant2PrimaryOrgUserRole.Write => "write",
                ResponseNewTitleAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseNewTitleAuthorVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewTitleAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseNewTitleAuthorVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseNewTitleAuthorVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseNewTitleAuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseNewTitleAuthorVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}