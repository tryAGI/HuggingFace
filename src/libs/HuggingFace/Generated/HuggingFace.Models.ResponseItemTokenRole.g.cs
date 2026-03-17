
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemTokenRole
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
    public static class ResponseItemTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemTokenRole value)
        {
            return value switch
            {
                ResponseItemTokenRole.Read => "read",
                ResponseItemTokenRole.Write => "write",
                ResponseItemTokenRole.FineGrained => "fineGrained",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "read" => ResponseItemTokenRole.Read,
                "write" => ResponseItemTokenRole.Write,
                "fineGrained" => ResponseItemTokenRole.FineGrained,
                _ => null,
            };
        }
    }
}