
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole7
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
    public static class ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole7 value)
        {
            return value switch
            {
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole7.Admin => "admin",
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole7.Write => "write",
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole7.Contributor => "contributor",
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole7.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole7? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole7.Admin,
                "write" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole7.Write,
                "contributor" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole7.Contributor,
                "read" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole7.Read,
                _ => null,
            };
        }
    }
}