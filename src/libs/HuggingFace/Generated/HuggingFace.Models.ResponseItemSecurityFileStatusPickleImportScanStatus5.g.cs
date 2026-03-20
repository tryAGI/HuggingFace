
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusPickleImportScanStatus5
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
    public static class ResponseItemSecurityFileStatusPickleImportScanStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusPickleImportScanStatus5 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusPickleImportScanStatus5.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusPickleImportScanStatus5.Safe => "safe",
                ResponseItemSecurityFileStatusPickleImportScanStatus5.Queued => "queued",
                ResponseItemSecurityFileStatusPickleImportScanStatus5.Error => "error",
                ResponseItemSecurityFileStatusPickleImportScanStatus5.Caution => "caution",
                ResponseItemSecurityFileStatusPickleImportScanStatus5.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusPickleImportScanStatus5.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusPickleImportScanStatus5? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusPickleImportScanStatus5.Unscanned,
                "safe" => ResponseItemSecurityFileStatusPickleImportScanStatus5.Safe,
                "queued" => ResponseItemSecurityFileStatusPickleImportScanStatus5.Queued,
                "error" => ResponseItemSecurityFileStatusPickleImportScanStatus5.Error,
                "caution" => ResponseItemSecurityFileStatusPickleImportScanStatus5.Caution,
                "suspicious" => ResponseItemSecurityFileStatusPickleImportScanStatus5.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusPickleImportScanStatus5.Unsafe,
                _ => null,
            };
        }
    }
}