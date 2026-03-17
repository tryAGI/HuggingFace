
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseJobSpecHfTokenTokenRole3
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
    public static class ResponseJobSpecHfTokenTokenRole3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseJobSpecHfTokenTokenRole3 value)
        {
            return value switch
            {
                ResponseJobSpecHfTokenTokenRole3.Read => "read",
                ResponseJobSpecHfTokenTokenRole3.Write => "write",
                ResponseJobSpecHfTokenTokenRole3.FineGrained => "fineGrained",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseJobSpecHfTokenTokenRole3? ToEnum(string value)
        {
            return value switch
            {
                "read" => ResponseJobSpecHfTokenTokenRole3.Read,
                "write" => ResponseJobSpecHfTokenTokenRole3.Write,
                "fineGrained" => ResponseJobSpecHfTokenTokenRole3.FineGrained,
                _ => null,
            };
        }
    }
}