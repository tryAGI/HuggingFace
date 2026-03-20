
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusProtectAiScanStatus4
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
    public static class ResponseItemSecurityFileStatusProtectAiScanStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusProtectAiScanStatus4 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusProtectAiScanStatus4.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusProtectAiScanStatus4.Safe => "safe",
                ResponseItemSecurityFileStatusProtectAiScanStatus4.Queued => "queued",
                ResponseItemSecurityFileStatusProtectAiScanStatus4.Error => "error",
                ResponseItemSecurityFileStatusProtectAiScanStatus4.Caution => "caution",
                ResponseItemSecurityFileStatusProtectAiScanStatus4.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusProtectAiScanStatus4.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusProtectAiScanStatus4? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusProtectAiScanStatus4.Unscanned,
                "safe" => ResponseItemSecurityFileStatusProtectAiScanStatus4.Safe,
                "queued" => ResponseItemSecurityFileStatusProtectAiScanStatus4.Queued,
                "error" => ResponseItemSecurityFileStatusProtectAiScanStatus4.Error,
                "caution" => ResponseItemSecurityFileStatusProtectAiScanStatus4.Caution,
                "suspicious" => ResponseItemSecurityFileStatusProtectAiScanStatus4.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusProtectAiScanStatus4.Unsafe,
                _ => null,
            };
        }
    }
}