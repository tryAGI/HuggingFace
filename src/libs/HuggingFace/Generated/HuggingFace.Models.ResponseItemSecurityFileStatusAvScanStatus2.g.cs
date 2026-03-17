
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusAvScanStatus2
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
    public static class ResponseItemSecurityFileStatusAvScanStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusAvScanStatus2 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusAvScanStatus2.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusAvScanStatus2.Safe => "safe",
                ResponseItemSecurityFileStatusAvScanStatus2.Queued => "queued",
                ResponseItemSecurityFileStatusAvScanStatus2.Error => "error",
                ResponseItemSecurityFileStatusAvScanStatus2.Caution => "caution",
                ResponseItemSecurityFileStatusAvScanStatus2.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusAvScanStatus2.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusAvScanStatus2? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusAvScanStatus2.Unscanned,
                "safe" => ResponseItemSecurityFileStatusAvScanStatus2.Safe,
                "queued" => ResponseItemSecurityFileStatusAvScanStatus2.Queued,
                "error" => ResponseItemSecurityFileStatusAvScanStatus2.Error,
                "caution" => ResponseItemSecurityFileStatusAvScanStatus2.Caution,
                "suspicious" => ResponseItemSecurityFileStatusAvScanStatus2.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusAvScanStatus2.Unsafe,
                _ => null,
            };
        }
    }
}