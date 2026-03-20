
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusProtectAiScanStatus6
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
    public static class ResponseItemSecurityFileStatusProtectAiScanStatus6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusProtectAiScanStatus6 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusProtectAiScanStatus6.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusProtectAiScanStatus6.Safe => "safe",
                ResponseItemSecurityFileStatusProtectAiScanStatus6.Queued => "queued",
                ResponseItemSecurityFileStatusProtectAiScanStatus6.Error => "error",
                ResponseItemSecurityFileStatusProtectAiScanStatus6.Caution => "caution",
                ResponseItemSecurityFileStatusProtectAiScanStatus6.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusProtectAiScanStatus6.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusProtectAiScanStatus6? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusProtectAiScanStatus6.Unscanned,
                "safe" => ResponseItemSecurityFileStatusProtectAiScanStatus6.Safe,
                "queued" => ResponseItemSecurityFileStatusProtectAiScanStatus6.Queued,
                "error" => ResponseItemSecurityFileStatusProtectAiScanStatus6.Error,
                "caution" => ResponseItemSecurityFileStatusProtectAiScanStatus6.Caution,
                "suspicious" => ResponseItemSecurityFileStatusProtectAiScanStatus6.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusProtectAiScanStatus6.Unsafe,
                _ => null,
            };
        }
    }
}