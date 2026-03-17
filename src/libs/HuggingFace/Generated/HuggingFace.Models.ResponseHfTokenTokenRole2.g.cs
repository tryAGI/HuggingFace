
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseHfTokenTokenRole2
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
    public static class ResponseHfTokenTokenRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseHfTokenTokenRole2 value)
        {
            return value switch
            {
                ResponseHfTokenTokenRole2.Read => "read",
                ResponseHfTokenTokenRole2.Write => "write",
                ResponseHfTokenTokenRole2.FineGrained => "fineGrained",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseHfTokenTokenRole2? ToEnum(string value)
        {
            return value switch
            {
                "read" => ResponseHfTokenTokenRole2.Read,
                "write" => ResponseHfTokenTokenRole2.Write,
                "fineGrained" => ResponseHfTokenTokenRole2.FineGrained,
                _ => null,
            };
        }
    }
}