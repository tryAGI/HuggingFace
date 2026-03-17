
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusProtectAiScanStatus
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
    public static class ResponseItemSecurityFileStatusProtectAiScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusProtectAiScanStatus value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusProtectAiScanStatus.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusProtectAiScanStatus.Safe => "safe",
                ResponseItemSecurityFileStatusProtectAiScanStatus.Queued => "queued",
                ResponseItemSecurityFileStatusProtectAiScanStatus.Error => "error",
                ResponseItemSecurityFileStatusProtectAiScanStatus.Caution => "caution",
                ResponseItemSecurityFileStatusProtectAiScanStatus.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusProtectAiScanStatus.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusProtectAiScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusProtectAiScanStatus.Unscanned,
                "safe" => ResponseItemSecurityFileStatusProtectAiScanStatus.Safe,
                "queued" => ResponseItemSecurityFileStatusProtectAiScanStatus.Queued,
                "error" => ResponseItemSecurityFileStatusProtectAiScanStatus.Error,
                "caution" => ResponseItemSecurityFileStatusProtectAiScanStatus.Caution,
                "suspicious" => ResponseItemSecurityFileStatusProtectAiScanStatus.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusProtectAiScanStatus.Unsafe,
                _ => null,
            };
        }
    }
}