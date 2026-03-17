
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole
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
    public static class ResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole.Write => "write",
                ResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseVariant2EventVariant1DataLatestAuthorVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}