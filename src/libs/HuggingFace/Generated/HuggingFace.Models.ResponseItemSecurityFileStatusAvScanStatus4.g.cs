
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusAvScanStatus4
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
    public static class ResponseItemSecurityFileStatusAvScanStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusAvScanStatus4 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusAvScanStatus4.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusAvScanStatus4.Safe => "safe",
                ResponseItemSecurityFileStatusAvScanStatus4.Queued => "queued",
                ResponseItemSecurityFileStatusAvScanStatus4.Error => "error",
                ResponseItemSecurityFileStatusAvScanStatus4.Caution => "caution",
                ResponseItemSecurityFileStatusAvScanStatus4.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusAvScanStatus4.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusAvScanStatus4? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusAvScanStatus4.Unscanned,
                "safe" => ResponseItemSecurityFileStatusAvScanStatus4.Safe,
                "queued" => ResponseItemSecurityFileStatusAvScanStatus4.Queued,
                "error" => ResponseItemSecurityFileStatusAvScanStatus4.Error,
                "caution" => ResponseItemSecurityFileStatusAvScanStatus4.Caution,
                "suspicious" => ResponseItemSecurityFileStatusAvScanStatus4.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusAvScanStatus4.Unsafe,
                _ => null,
            };
        }
    }
}