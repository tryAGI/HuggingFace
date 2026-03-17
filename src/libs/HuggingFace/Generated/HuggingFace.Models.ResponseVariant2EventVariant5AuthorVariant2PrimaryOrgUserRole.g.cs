
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgUserRole
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
    public static class ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgUserRole.Write => "write",
                ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseVariant2EventVariant5AuthorVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}