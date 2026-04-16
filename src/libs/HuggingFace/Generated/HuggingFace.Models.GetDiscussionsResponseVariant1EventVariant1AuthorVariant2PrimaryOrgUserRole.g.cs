
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrgUserRole
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
        NoAccess,
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
    public static class GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrgUserRole.Read => "read",
                GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrgUserRole.NoAccess,
                "read" => GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrgUserRole.Read,
                "write" => GetDiscussionsResponseVariant1EventVariant1AuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}