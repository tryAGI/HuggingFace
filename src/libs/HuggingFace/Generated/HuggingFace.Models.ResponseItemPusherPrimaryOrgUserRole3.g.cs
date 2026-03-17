
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemPusherPrimaryOrgUserRole3
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
    public static class ResponseItemPusherPrimaryOrgUserRole3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemPusherPrimaryOrgUserRole3 value)
        {
            return value switch
            {
                ResponseItemPusherPrimaryOrgUserRole3.Admin => "admin",
                ResponseItemPusherPrimaryOrgUserRole3.Write => "write",
                ResponseItemPusherPrimaryOrgUserRole3.Contributor => "contributor",
                ResponseItemPusherPrimaryOrgUserRole3.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemPusherPrimaryOrgUserRole3? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseItemPusherPrimaryOrgUserRole3.Admin,
                "write" => ResponseItemPusherPrimaryOrgUserRole3.Write,
                "contributor" => ResponseItemPusherPrimaryOrgUserRole3.Contributor,
                "read" => ResponseItemPusherPrimaryOrgUserRole3.Read,
                _ => null,
            };
        }
    }
}