
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageAuthorVariant2PrimaryOrgUserRole7
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
    public static class ResponseNewMessageAuthorVariant2PrimaryOrgUserRole7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageAuthorVariant2PrimaryOrgUserRole7 value)
        {
            return value switch
            {
                ResponseNewMessageAuthorVariant2PrimaryOrgUserRole7.Admin => "admin",
                ResponseNewMessageAuthorVariant2PrimaryOrgUserRole7.Write => "write",
                ResponseNewMessageAuthorVariant2PrimaryOrgUserRole7.Contributor => "contributor",
                ResponseNewMessageAuthorVariant2PrimaryOrgUserRole7.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageAuthorVariant2PrimaryOrgUserRole7? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseNewMessageAuthorVariant2PrimaryOrgUserRole7.Admin,
                "write" => ResponseNewMessageAuthorVariant2PrimaryOrgUserRole7.Write,
                "contributor" => ResponseNewMessageAuthorVariant2PrimaryOrgUserRole7.Contributor,
                "read" => ResponseNewMessageAuthorVariant2PrimaryOrgUserRole7.Read,
                _ => null,
            };
        }
    }
}