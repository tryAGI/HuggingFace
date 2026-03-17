
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseHfTokenTokenRole3
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
    public static class ResponseHfTokenTokenRole3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseHfTokenTokenRole3 value)
        {
            return value switch
            {
                ResponseHfTokenTokenRole3.Read => "read",
                ResponseHfTokenTokenRole3.Write => "write",
                ResponseHfTokenTokenRole3.FineGrained => "fineGrained",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseHfTokenTokenRole3? ToEnum(string value)
        {
            return value switch
            {
                "read" => ResponseHfTokenTokenRole3.Read,
                "write" => ResponseHfTokenTokenRole3.Write,
                "fineGrained" => ResponseHfTokenTokenRole3.FineGrained,
                _ => null,
            };
        }
    }
}