
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole5
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
    public static class ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole5 value)
        {
            return value switch
            {
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole5.Admin => "admin",
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole5.Write => "write",
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole5.Contributor => "contributor",
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole5.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole5? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole5.Admin,
                "write" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole5.Write,
                "contributor" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole5.Contributor,
                "read" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole5.Read,
                _ => null,
            };
        }
    }
}