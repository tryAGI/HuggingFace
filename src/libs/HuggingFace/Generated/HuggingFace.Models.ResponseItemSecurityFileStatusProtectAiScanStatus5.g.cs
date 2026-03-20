
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusProtectAiScanStatus5
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
    public static class ResponseItemSecurityFileStatusProtectAiScanStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusProtectAiScanStatus5 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusProtectAiScanStatus5.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusProtectAiScanStatus5.Safe => "safe",
                ResponseItemSecurityFileStatusProtectAiScanStatus5.Queued => "queued",
                ResponseItemSecurityFileStatusProtectAiScanStatus5.Error => "error",
                ResponseItemSecurityFileStatusProtectAiScanStatus5.Caution => "caution",
                ResponseItemSecurityFileStatusProtectAiScanStatus5.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusProtectAiScanStatus5.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusProtectAiScanStatus5? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusProtectAiScanStatus5.Unscanned,
                "safe" => ResponseItemSecurityFileStatusProtectAiScanStatus5.Safe,
                "queued" => ResponseItemSecurityFileStatusProtectAiScanStatus5.Queued,
                "error" => ResponseItemSecurityFileStatusProtectAiScanStatus5.Error,
                "caution" => ResponseItemSecurityFileStatusProtectAiScanStatus5.Caution,
                "suspicious" => ResponseItemSecurityFileStatusProtectAiScanStatus5.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusProtectAiScanStatus5.Unsafe,
                _ => null,
            };
        }
    }
}