
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageAuthorVariant2PrimaryOrgUserRole3
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
    public static class ResponseNewMessageAuthorVariant2PrimaryOrgUserRole3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageAuthorVariant2PrimaryOrgUserRole3 value)
        {
            return value switch
            {
                ResponseNewMessageAuthorVariant2PrimaryOrgUserRole3.Admin => "admin",
                ResponseNewMessageAuthorVariant2PrimaryOrgUserRole3.Write => "write",
                ResponseNewMessageAuthorVariant2PrimaryOrgUserRole3.Contributor => "contributor",
                ResponseNewMessageAuthorVariant2PrimaryOrgUserRole3.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageAuthorVariant2PrimaryOrgUserRole3? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseNewMessageAuthorVariant2PrimaryOrgUserRole3.Admin,
                "write" => ResponseNewMessageAuthorVariant2PrimaryOrgUserRole3.Write,
                "contributor" => ResponseNewMessageAuthorVariant2PrimaryOrgUserRole3.Contributor,
                "read" => ResponseNewMessageAuthorVariant2PrimaryOrgUserRole3.Read,
                _ => null,
            };
        }
    }
}