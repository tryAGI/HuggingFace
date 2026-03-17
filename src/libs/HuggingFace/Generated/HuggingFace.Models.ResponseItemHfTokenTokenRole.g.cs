
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemHfTokenTokenRole
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
    public static class ResponseItemHfTokenTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemHfTokenTokenRole value)
        {
            return value switch
            {
                ResponseItemHfTokenTokenRole.Read => "read",
                ResponseItemHfTokenTokenRole.Write => "write",
                ResponseItemHfTokenTokenRole.FineGrained => "fineGrained",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemHfTokenTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "read" => ResponseItemHfTokenTokenRole.Read,
                "write" => ResponseItemHfTokenTokenRole.Write,
                "fineGrained" => ResponseItemHfTokenTokenRole.FineGrained,
                _ => null,
            };
        }
    }
}