
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusJFrogScanStatus3
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
    public static class ResponseItemSecurityFileStatusJFrogScanStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusJFrogScanStatus3 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusJFrogScanStatus3.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusJFrogScanStatus3.Safe => "safe",
                ResponseItemSecurityFileStatusJFrogScanStatus3.Queued => "queued",
                ResponseItemSecurityFileStatusJFrogScanStatus3.Error => "error",
                ResponseItemSecurityFileStatusJFrogScanStatus3.Caution => "caution",
                ResponseItemSecurityFileStatusJFrogScanStatus3.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusJFrogScanStatus3.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusJFrogScanStatus3? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusJFrogScanStatus3.Unscanned,
                "safe" => ResponseItemSecurityFileStatusJFrogScanStatus3.Safe,
                "queued" => ResponseItemSecurityFileStatusJFrogScanStatus3.Queued,
                "error" => ResponseItemSecurityFileStatusJFrogScanStatus3.Error,
                "caution" => ResponseItemSecurityFileStatusJFrogScanStatus3.Caution,
                "suspicious" => ResponseItemSecurityFileStatusJFrogScanStatus3.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusJFrogScanStatus3.Unsafe,
                _ => null,
            };
        }
    }
}