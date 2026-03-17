
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusJFrogScanStatus2
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
    public static class ResponseItemSecurityFileStatusJFrogScanStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusJFrogScanStatus2 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusJFrogScanStatus2.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusJFrogScanStatus2.Safe => "safe",
                ResponseItemSecurityFileStatusJFrogScanStatus2.Queued => "queued",
                ResponseItemSecurityFileStatusJFrogScanStatus2.Error => "error",
                ResponseItemSecurityFileStatusJFrogScanStatus2.Caution => "caution",
                ResponseItemSecurityFileStatusJFrogScanStatus2.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusJFrogScanStatus2.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusJFrogScanStatus2? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusJFrogScanStatus2.Unscanned,
                "safe" => ResponseItemSecurityFileStatusJFrogScanStatus2.Safe,
                "queued" => ResponseItemSecurityFileStatusJFrogScanStatus2.Queued,
                "error" => ResponseItemSecurityFileStatusJFrogScanStatus2.Error,
                "caution" => ResponseItemSecurityFileStatusJFrogScanStatus2.Caution,
                "suspicious" => ResponseItemSecurityFileStatusJFrogScanStatus2.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusJFrogScanStatus2.Unsafe,
                _ => null,
            };
        }
    }
}