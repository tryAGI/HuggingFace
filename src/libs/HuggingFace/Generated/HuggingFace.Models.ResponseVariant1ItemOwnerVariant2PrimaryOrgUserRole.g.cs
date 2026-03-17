
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole
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
    public static class ResponseVariant1ItemOwnerVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole.Write => "write",
                ResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseVariant1ItemOwnerVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}