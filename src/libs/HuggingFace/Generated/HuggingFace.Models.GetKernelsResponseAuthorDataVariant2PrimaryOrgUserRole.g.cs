
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole
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
    public static class GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole.Admin => "admin",
                GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole.Contributor => "contributor",
                GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole.Read => "read",
                GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole.Admin,
                "contributor" => GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole.Contributor,
                "read" => GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole.Read,
                "write" => GetKernelsResponseAuthorDataVariant2PrimaryOrgUserRole.Write,
                _ => null,
            };
        }
    }
}