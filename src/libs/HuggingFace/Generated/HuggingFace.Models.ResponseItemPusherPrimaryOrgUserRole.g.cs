
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemPusherPrimaryOrgUserRole
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
    public static class ResponseItemPusherPrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemPusherPrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseItemPusherPrimaryOrgUserRole.Admin => "admin",
                ResponseItemPusherPrimaryOrgUserRole.Write => "write",
                ResponseItemPusherPrimaryOrgUserRole.Contributor => "contributor",
                ResponseItemPusherPrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemPusherPrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseItemPusherPrimaryOrgUserRole.Admin,
                "write" => ResponseItemPusherPrimaryOrgUserRole.Write,
                "contributor" => ResponseItemPusherPrimaryOrgUserRole.Contributor,
                "read" => ResponseItemPusherPrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}