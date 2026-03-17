
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseJobSpecHfTokenTokenRole2
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
    public static class ResponseJobSpecHfTokenTokenRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseJobSpecHfTokenTokenRole2 value)
        {
            return value switch
            {
                ResponseJobSpecHfTokenTokenRole2.Read => "read",
                ResponseJobSpecHfTokenTokenRole2.Write => "write",
                ResponseJobSpecHfTokenTokenRole2.FineGrained => "fineGrained",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseJobSpecHfTokenTokenRole2? ToEnum(string value)
        {
            return value switch
            {
                "read" => ResponseJobSpecHfTokenTokenRole2.Read,
                "write" => ResponseJobSpecHfTokenTokenRole2.Write,
                "fineGrained" => ResponseJobSpecHfTokenTokenRole2.FineGrained,
                _ => null,
            };
        }
    }
}