
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemJobSpecHfTokenTokenRole
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
        /// <summary>
        /// 
        /// </summary>
        FineGrained,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemJobSpecHfTokenTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemJobSpecHfTokenTokenRole value)
        {
            return value switch
            {
                ResponseItemJobSpecHfTokenTokenRole.Read => "read",
                ResponseItemJobSpecHfTokenTokenRole.Write => "write",
                ResponseItemJobSpecHfTokenTokenRole.FineGrained => "fineGrained",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemJobSpecHfTokenTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "read" => ResponseItemJobSpecHfTokenTokenRole.Read,
                "write" => ResponseItemJobSpecHfTokenTokenRole.Write,
                "fineGrained" => ResponseItemJobSpecHfTokenTokenRole.FineGrained,
                _ => null,
            };
        }
    }
}