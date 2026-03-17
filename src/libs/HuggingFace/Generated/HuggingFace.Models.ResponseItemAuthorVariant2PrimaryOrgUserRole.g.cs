
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemAuthorVariant2PrimaryOrgUserRole
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
    public static class ResponseItemAuthorVariant2PrimaryOrgUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemAuthorVariant2PrimaryOrgUserRole value)
        {
            return value switch
            {
                ResponseItemAuthorVariant2PrimaryOrgUserRole.Admin => "admin",
                ResponseItemAuthorVariant2PrimaryOrgUserRole.Write => "write",
                ResponseItemAuthorVariant2PrimaryOrgUserRole.Contributor => "contributor",
                ResponseItemAuthorVariant2PrimaryOrgUserRole.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemAuthorVariant2PrimaryOrgUserRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => ResponseItemAuthorVariant2PrimaryOrgUserRole.Admin,
                "write" => ResponseItemAuthorVariant2PrimaryOrgUserRole.Write,
                "contributor" => ResponseItemAuthorVariant2PrimaryOrgUserRole.Contributor,
                "read" => ResponseItemAuthorVariant2PrimaryOrgUserRole.Read,
                _ => null,
            };
        }
    }
}