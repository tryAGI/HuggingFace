
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole
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
    public static class GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole.Read => "read",
                GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole.Admin,
                "contributor" => GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole.NoAccess,
                "read" => GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole.Read,
                "write" => GetDiscussionsResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}