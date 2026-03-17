
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole
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
    public static class ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Write => "write",
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseNewMessageDataLatestAuthorVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}