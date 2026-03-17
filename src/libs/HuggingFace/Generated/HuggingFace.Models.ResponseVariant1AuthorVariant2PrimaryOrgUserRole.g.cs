
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1AuthorVariant2PrimaryOrgUserRole
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
    public static class ResponseVariant1AuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1AuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseVariant1AuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseVariant1AuthorVariant2PrimaryOrgUserRole.Write => "write",
                ResponseVariant1AuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseVariant1AuthorVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1AuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseVariant1AuthorVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseVariant1AuthorVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseVariant1AuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseVariant1AuthorVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}