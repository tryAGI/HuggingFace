
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseHfTokenTokenRole5
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
    public static class ResponseHfTokenTokenRole5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseHfTokenTokenRole5 value)
        {
            return value switch
            {
                ResponseHfTokenTokenRole5.Read => "read",
                ResponseHfTokenTokenRole5.Write => "write",
                ResponseHfTokenTokenRole5.FineGrained => "fineGrained",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseHfTokenTokenRole5? ToEnum(string value)
        {
            return value switch
            {
                "read" => ResponseHfTokenTokenRole5.Read,
                "write" => ResponseHfTokenTokenRole5.Write,
                "fineGrained" => ResponseHfTokenTokenRole5.FineGrained,
                _ => null,
            };
        }
    }
}