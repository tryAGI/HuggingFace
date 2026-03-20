
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusProtectAiScanStatus3
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
    public static class ResponseItemSecurityFileStatusProtectAiScanStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusProtectAiScanStatus3 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusProtectAiScanStatus3.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusProtectAiScanStatus3.Safe => "safe",
                ResponseItemSecurityFileStatusProtectAiScanStatus3.Queued => "queued",
                ResponseItemSecurityFileStatusProtectAiScanStatus3.Error => "error",
                ResponseItemSecurityFileStatusProtectAiScanStatus3.Caution => "caution",
                ResponseItemSecurityFileStatusProtectAiScanStatus3.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusProtectAiScanStatus3.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusProtectAiScanStatus3? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusProtectAiScanStatus3.Unscanned,
                "safe" => ResponseItemSecurityFileStatusProtectAiScanStatus3.Safe,
                "queued" => ResponseItemSecurityFileStatusProtectAiScanStatus3.Queued,
                "error" => ResponseItemSecurityFileStatusProtectAiScanStatus3.Error,
                "caution" => ResponseItemSecurityFileStatusProtectAiScanStatus3.Caution,
                "suspicious" => ResponseItemSecurityFileStatusProtectAiScanStatus3.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusProtectAiScanStatus3.Unsafe,
                _ => null,
            };
        }
    }
}