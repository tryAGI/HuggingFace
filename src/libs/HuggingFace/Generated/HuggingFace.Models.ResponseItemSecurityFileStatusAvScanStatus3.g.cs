
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusAvScanStatus3
    {
        /// <summary>
        /// 
        /// </summary>
        Unscanned,
        /// <summary>
        /// 
        /// </summary>
        Safe,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Caution,
        /// <summary>
        /// 
        /// </summary>
        Suspicious,
        /// <summary>
        /// 
        /// </summary>
        Unsafe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemSecurityFileStatusAvScanStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusAvScanStatus3 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusAvScanStatus3.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusAvScanStatus3.Safe => "safe",
                ResponseItemSecurityFileStatusAvScanStatus3.Queued => "queued",
                ResponseItemSecurityFileStatusAvScanStatus3.Error => "error",
                ResponseItemSecurityFileStatusAvScanStatus3.Caution => "caution",
                ResponseItemSecurityFileStatusAvScanStatus3.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusAvScanStatus3.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusAvScanStatus3? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusAvScanStatus3.Unscanned,
                "safe" => ResponseItemSecurityFileStatusAvScanStatus3.Safe,
                "queued" => ResponseItemSecurityFileStatusAvScanStatus3.Queued,
                "error" => ResponseItemSecurityFileStatusAvScanStatus3.Error,
                "caution" => ResponseItemSecurityFileStatusAvScanStatus3.Caution,
                "suspicious" => ResponseItemSecurityFileStatusAvScanStatus3.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusAvScanStatus3.Unsafe,
                _ => null,
            };
        }
    }
}