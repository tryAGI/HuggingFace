
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusJFrogScanStatus4
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
    public static class ResponseItemSecurityFileStatusJFrogScanStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusJFrogScanStatus4 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusJFrogScanStatus4.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusJFrogScanStatus4.Safe => "safe",
                ResponseItemSecurityFileStatusJFrogScanStatus4.Queued => "queued",
                ResponseItemSecurityFileStatusJFrogScanStatus4.Error => "error",
                ResponseItemSecurityFileStatusJFrogScanStatus4.Caution => "caution",
                ResponseItemSecurityFileStatusJFrogScanStatus4.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusJFrogScanStatus4.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusJFrogScanStatus4? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusJFrogScanStatus4.Unscanned,
                "safe" => ResponseItemSecurityFileStatusJFrogScanStatus4.Safe,
                "queued" => ResponseItemSecurityFileStatusJFrogScanStatus4.Queued,
                "error" => ResponseItemSecurityFileStatusJFrogScanStatus4.Error,
                "caution" => ResponseItemSecurityFileStatusJFrogScanStatus4.Caution,
                "suspicious" => ResponseItemSecurityFileStatusJFrogScanStatus4.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusJFrogScanStatus4.Unsafe,
                _ => null,
            };
        }
    }
}