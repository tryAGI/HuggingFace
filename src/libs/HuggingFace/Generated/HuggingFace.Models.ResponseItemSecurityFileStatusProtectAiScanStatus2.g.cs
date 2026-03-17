
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusProtectAiScanStatus2
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
    public static class ResponseItemSecurityFileStatusProtectAiScanStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusProtectAiScanStatus2 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusProtectAiScanStatus2.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusProtectAiScanStatus2.Safe => "safe",
                ResponseItemSecurityFileStatusProtectAiScanStatus2.Queued => "queued",
                ResponseItemSecurityFileStatusProtectAiScanStatus2.Error => "error",
                ResponseItemSecurityFileStatusProtectAiScanStatus2.Caution => "caution",
                ResponseItemSecurityFileStatusProtectAiScanStatus2.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusProtectAiScanStatus2.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusProtectAiScanStatus2? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusProtectAiScanStatus2.Unscanned,
                "safe" => ResponseItemSecurityFileStatusProtectAiScanStatus2.Safe,
                "queued" => ResponseItemSecurityFileStatusProtectAiScanStatus2.Queued,
                "error" => ResponseItemSecurityFileStatusProtectAiScanStatus2.Error,
                "caution" => ResponseItemSecurityFileStatusProtectAiScanStatus2.Caution,
                "suspicious" => ResponseItemSecurityFileStatusProtectAiScanStatus2.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusProtectAiScanStatus2.Unsafe,
                _ => null,
            };
        }
    }
}