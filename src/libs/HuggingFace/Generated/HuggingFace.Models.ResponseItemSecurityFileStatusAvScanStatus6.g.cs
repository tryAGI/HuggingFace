
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusAvScanStatus6
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
    public static class ResponseItemSecurityFileStatusAvScanStatus6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusAvScanStatus6 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusAvScanStatus6.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusAvScanStatus6.Safe => "safe",
                ResponseItemSecurityFileStatusAvScanStatus6.Queued => "queued",
                ResponseItemSecurityFileStatusAvScanStatus6.Error => "error",
                ResponseItemSecurityFileStatusAvScanStatus6.Caution => "caution",
                ResponseItemSecurityFileStatusAvScanStatus6.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusAvScanStatus6.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusAvScanStatus6? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusAvScanStatus6.Unscanned,
                "safe" => ResponseItemSecurityFileStatusAvScanStatus6.Safe,
                "queued" => ResponseItemSecurityFileStatusAvScanStatus6.Queued,
                "error" => ResponseItemSecurityFileStatusAvScanStatus6.Error,
                "caution" => ResponseItemSecurityFileStatusAvScanStatus6.Caution,
                "suspicious" => ResponseItemSecurityFileStatusAvScanStatus6.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusAvScanStatus6.Unsafe,
                _ => null,
            };
        }
    }
}