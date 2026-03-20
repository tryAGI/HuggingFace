
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusJFrogScanStatus6
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
    public static class ResponseItemSecurityFileStatusJFrogScanStatus6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusJFrogScanStatus6 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusJFrogScanStatus6.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusJFrogScanStatus6.Safe => "safe",
                ResponseItemSecurityFileStatusJFrogScanStatus6.Queued => "queued",
                ResponseItemSecurityFileStatusJFrogScanStatus6.Error => "error",
                ResponseItemSecurityFileStatusJFrogScanStatus6.Caution => "caution",
                ResponseItemSecurityFileStatusJFrogScanStatus6.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusJFrogScanStatus6.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusJFrogScanStatus6? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusJFrogScanStatus6.Unscanned,
                "safe" => ResponseItemSecurityFileStatusJFrogScanStatus6.Safe,
                "queued" => ResponseItemSecurityFileStatusJFrogScanStatus6.Queued,
                "error" => ResponseItemSecurityFileStatusJFrogScanStatus6.Error,
                "caution" => ResponseItemSecurityFileStatusJFrogScanStatus6.Caution,
                "suspicious" => ResponseItemSecurityFileStatusJFrogScanStatus6.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusJFrogScanStatus6.Unsafe,
                _ => null,
            };
        }
    }
}