
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole
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
    public static class GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole.Admin => "admin",
                GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole.Contributor => "contributor",
                GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole.NoAccess => "no_access",
                GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole.Read => "read",
                GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole.Admin,
                "contributor" => GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole.Contributor,
                "no_access" => GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole.NoAccess,
                "read" => GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole.Read,
                "write" => GetKernelsRevisionResponseAuthorDataVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}