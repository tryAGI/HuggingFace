
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemPusherPrimaryOrgUserRole2
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
    public static class ResponseItemPusherPrimaryOrgUserRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemPusherPrimaryOrgUserRole2 value)
        {
            return value switch
            {
                ResponseItemPusherPrimaryOrgUserRole2.Admin => "admin",
                ResponseItemPusherPrimaryOrgUserRole2.Write => "write",
                ResponseItemPusherPrimaryOrgUserRole2.Contributor => "contributor",
                ResponseItemPusherPrimaryOrgUserRole2.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemPusherPrimaryOrgUserRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseItemPusherPrimaryOrgUserRole2.Admin,
                "write" => ResponseItemPusherPrimaryOrgUserRole2.Write,
                "contributor" => ResponseItemPusherPrimaryOrgUserRole2.Contributor,
                "read" => ResponseItemPusherPrimaryOrgUserRole2.Read,
                _ => null,
            };
        }
    }
}