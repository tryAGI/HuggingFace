
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseAuthorDataVariant2PrimaryOrgUserRole
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
    public static class ResponseAuthorDataVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAuthorDataVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseAuthorDataVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseAuthorDataVariant2PrimaryOrgUserRole.Write => "write",
                ResponseAuthorDataVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseAuthorDataVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAuthorDataVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseAuthorDataVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseAuthorDataVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseAuthorDataVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseAuthorDataVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}