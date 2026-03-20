
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusPickleImportScanStatus3
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
    public static class ResponseItemSecurityFileStatusPickleImportScanStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusPickleImportScanStatus3 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusPickleImportScanStatus3.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusPickleImportScanStatus3.Safe => "safe",
                ResponseItemSecurityFileStatusPickleImportScanStatus3.Queued => "queued",
                ResponseItemSecurityFileStatusPickleImportScanStatus3.Error => "error",
                ResponseItemSecurityFileStatusPickleImportScanStatus3.Caution => "caution",
                ResponseItemSecurityFileStatusPickleImportScanStatus3.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusPickleImportScanStatus3.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusPickleImportScanStatus3? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusPickleImportScanStatus3.Unscanned,
                "safe" => ResponseItemSecurityFileStatusPickleImportScanStatus3.Safe,
                "queued" => ResponseItemSecurityFileStatusPickleImportScanStatus3.Queued,
                "error" => ResponseItemSecurityFileStatusPickleImportScanStatus3.Error,
                "caution" => ResponseItemSecurityFileStatusPickleImportScanStatus3.Caution,
                "suspicious" => ResponseItemSecurityFileStatusPickleImportScanStatus3.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusPickleImportScanStatus3.Unsafe,
                _ => null,
            };
        }
    }
}