
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageAuthorVariant2PrimaryOrgUserRole4
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
    public static class ResponseNewMessageAuthorVariant2PrimaryOrgUserRole4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageAuthorVariant2PrimaryOrgUserRole4 value)
        {
            return value switch
            {
                ResponseNewMessageAuthorVariant2PrimaryOrgUserRole4.Admin => "admin",
                ResponseNewMessageAuthorVariant2PrimaryOrgUserRole4.Write => "write",
                ResponseNewMessageAuthorVariant2PrimaryOrgUserRole4.Contributor => "contributor",
                ResponseNewMessageAuthorVariant2PrimaryOrgUserRole4.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageAuthorVariant2PrimaryOrgUserRole4? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseNewMessageAuthorVariant2PrimaryOrgUserRole4.Admin,
                "write" => ResponseNewMessageAuthorVariant2PrimaryOrgUserRole4.Write,
                "contributor" => ResponseNewMessageAuthorVariant2PrimaryOrgUserRole4.Contributor,
                "read" => ResponseNewMessageAuthorVariant2PrimaryOrgUserRole4.Read,
                _ => null,
            };
        }
    }
}