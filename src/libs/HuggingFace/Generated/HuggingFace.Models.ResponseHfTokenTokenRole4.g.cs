
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseHfTokenTokenRole4
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
    public static class ResponseHfTokenTokenRole4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseHfTokenTokenRole4 value)
        {
            return value switch
            {
                ResponseHfTokenTokenRole4.Read => "read",
                ResponseHfTokenTokenRole4.Write => "write",
                ResponseHfTokenTokenRole4.FineGrained => "fineGrained",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseHfTokenTokenRole4? ToEnum(string value)
        {
            return value switch
            {
                "read" => ResponseHfTokenTokenRole4.Read,
                "write" => ResponseHfTokenTokenRole4.Write,
                "fineGrained" => ResponseHfTokenTokenRole4.FineGrained,
                _ => null,
            };
        }
    }
}