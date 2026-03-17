
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole
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
    public static class ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole.Write => "write",
                ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseDataItemVariant5OwnerVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}