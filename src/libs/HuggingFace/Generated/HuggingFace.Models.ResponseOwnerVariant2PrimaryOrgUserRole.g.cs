
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseOwnerVariant2PrimaryOrgUserRole
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
    public static class ResponseOwnerVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseOwnerVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseOwnerVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseOwnerVariant2PrimaryOrgUserRole.Write => "write",
                ResponseOwnerVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseOwnerVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseOwnerVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseOwnerVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseOwnerVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseOwnerVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseOwnerVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}