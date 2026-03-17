
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseJobSpecHfTokenTokenRole
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
    public static class ResponseJobSpecHfTokenTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseJobSpecHfTokenTokenRole value)
        {
            return value switch
            {
                ResponseJobSpecHfTokenTokenRole.Read => "read",
                ResponseJobSpecHfTokenTokenRole.Write => "write",
                ResponseJobSpecHfTokenTokenRole.FineGrained => "fineGrained",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseJobSpecHfTokenTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "read" => ResponseJobSpecHfTokenTokenRole.Read,
                "write" => ResponseJobSpecHfTokenTokenRole.Write,
                "fineGrained" => ResponseJobSpecHfTokenTokenRole.FineGrained,
                _ => null,
            };
        }
    }
}