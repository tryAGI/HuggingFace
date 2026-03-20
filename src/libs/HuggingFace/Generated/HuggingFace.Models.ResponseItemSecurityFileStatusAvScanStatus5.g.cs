
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusAvScanStatus5
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
    public static class ResponseItemSecurityFileStatusAvScanStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusAvScanStatus5 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusAvScanStatus5.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusAvScanStatus5.Safe => "safe",
                ResponseItemSecurityFileStatusAvScanStatus5.Queued => "queued",
                ResponseItemSecurityFileStatusAvScanStatus5.Error => "error",
                ResponseItemSecurityFileStatusAvScanStatus5.Caution => "caution",
                ResponseItemSecurityFileStatusAvScanStatus5.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusAvScanStatus5.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusAvScanStatus5? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusAvScanStatus5.Unscanned,
                "safe" => ResponseItemSecurityFileStatusAvScanStatus5.Safe,
                "queued" => ResponseItemSecurityFileStatusAvScanStatus5.Queued,
                "error" => ResponseItemSecurityFileStatusAvScanStatus5.Error,
                "caution" => ResponseItemSecurityFileStatusAvScanStatus5.Caution,
                "suspicious" => ResponseItemSecurityFileStatusAvScanStatus5.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusAvScanStatus5.Unsafe,
                _ => null,
            };
        }
    }
}