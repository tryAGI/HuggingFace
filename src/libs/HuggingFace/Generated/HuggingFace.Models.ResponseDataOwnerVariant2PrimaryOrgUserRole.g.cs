
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataOwnerVariant2PrimaryOrgUserRole
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
    public static class ResponseDataOwnerVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataOwnerVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseDataOwnerVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseDataOwnerVariant2PrimaryOrgUserRole.Write => "write",
                ResponseDataOwnerVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseDataOwnerVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataOwnerVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseDataOwnerVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseDataOwnerVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseDataOwnerVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseDataOwnerVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}