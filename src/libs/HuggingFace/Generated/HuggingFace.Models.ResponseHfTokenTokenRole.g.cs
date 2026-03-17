
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseHfTokenTokenRole
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
    public static class ResponseHfTokenTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseHfTokenTokenRole value)
        {
            return value switch
            {
                ResponseHfTokenTokenRole.Read => "read",
                ResponseHfTokenTokenRole.Write => "write",
                ResponseHfTokenTokenRole.FineGrained => "fineGrained",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseHfTokenTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "read" => ResponseHfTokenTokenRole.Read,
                "write" => ResponseHfTokenTokenRole.Write,
                "fineGrained" => ResponseHfTokenTokenRole.FineGrained,
                _ => null,
            };
        }
    }
}