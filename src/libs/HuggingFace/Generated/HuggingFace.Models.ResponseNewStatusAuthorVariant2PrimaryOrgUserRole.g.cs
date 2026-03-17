
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewStatusAuthorVariant2PrimaryOrgUserRole
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
    public static class ResponseNewStatusAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewStatusAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseNewStatusAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseNewStatusAuthorVariant2PrimaryOrgUserRole.Write => "write",
                ResponseNewStatusAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseNewStatusAuthorVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewStatusAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseNewStatusAuthorVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseNewStatusAuthorVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseNewStatusAuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseNewStatusAuthorVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}