
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseAuthAccessTokenRole
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
        God,
        /// <summary>
        /// 
        /// </summary>
        FineGrained,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseAuthAccessTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseAuthAccessTokenRole value)
        {
            return value switch
            {
                ResponseAuthAccessTokenRole.Read => "read",
                ResponseAuthAccessTokenRole.Write => "write",
                ResponseAuthAccessTokenRole.God => "god",
                ResponseAuthAccessTokenRole.FineGrained => "fineGrained",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseAuthAccessTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "read" => ResponseAuthAccessTokenRole.Read,
                "write" => ResponseAuthAccessTokenRole.Write,
                "god" => ResponseAuthAccessTokenRole.God,
                "fineGrained" => ResponseAuthAccessTokenRole.FineGrained,
                _ => null,
            };
        }
    }
}