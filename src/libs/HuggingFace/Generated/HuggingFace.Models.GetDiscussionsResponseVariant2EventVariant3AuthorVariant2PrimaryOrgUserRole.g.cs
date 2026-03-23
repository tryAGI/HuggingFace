
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseVariant2EventVariant3AuthorVariant2PrimaryOrgUserRole
    {
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Contributor,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDiscussionsResponseVariant2EventVariant3AuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseVariant2EventVariant3AuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                GetDiscussionsResponseVariant2EventVariant3AuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                GetDiscussionsResponseVariant2EventVariant3AuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                GetDiscussionsResponseVariant2EventVariant3AuthorVariant2PrimaryOrgUserRole.Read => "read",
                GetDiscussionsResponseVariant2EventVariant3AuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseVariant2EventVariant3AuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetDiscussionsResponseVariant2EventVariant3AuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => GetDiscussionsResponseVariant2EventVariant3AuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => GetDiscussionsResponseVariant2EventVariant3AuthorVariant2PrimaryOrgUserRole.Read,
                "write" => GetDiscussionsResponseVariant2EventVariant3AuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}