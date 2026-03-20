
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusJFrogScanStatus5
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
    public static class ResponseItemSecurityFileStatusJFrogScanStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusJFrogScanStatus5 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusJFrogScanStatus5.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusJFrogScanStatus5.Safe => "safe",
                ResponseItemSecurityFileStatusJFrogScanStatus5.Queued => "queued",
                ResponseItemSecurityFileStatusJFrogScanStatus5.Error => "error",
                ResponseItemSecurityFileStatusJFrogScanStatus5.Caution => "caution",
                ResponseItemSecurityFileStatusJFrogScanStatus5.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusJFrogScanStatus5.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusJFrogScanStatus5? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusJFrogScanStatus5.Unscanned,
                "safe" => ResponseItemSecurityFileStatusJFrogScanStatus5.Safe,
                "queued" => ResponseItemSecurityFileStatusJFrogScanStatus5.Queued,
                "error" => ResponseItemSecurityFileStatusJFrogScanStatus5.Error,
                "caution" => ResponseItemSecurityFileStatusJFrogScanStatus5.Caution,
                "suspicious" => ResponseItemSecurityFileStatusJFrogScanStatus5.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusJFrogScanStatus5.Unsafe,
                _ => null,
            };
        }
    }
}