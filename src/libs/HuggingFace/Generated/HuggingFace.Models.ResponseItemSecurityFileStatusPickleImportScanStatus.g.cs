
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusPickleImportScanStatus
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
    public static class ResponseItemSecurityFileStatusPickleImportScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusPickleImportScanStatus value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusPickleImportScanStatus.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusPickleImportScanStatus.Safe => "safe",
                ResponseItemSecurityFileStatusPickleImportScanStatus.Queued => "queued",
                ResponseItemSecurityFileStatusPickleImportScanStatus.Error => "error",
                ResponseItemSecurityFileStatusPickleImportScanStatus.Caution => "caution",
                ResponseItemSecurityFileStatusPickleImportScanStatus.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusPickleImportScanStatus.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusPickleImportScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusPickleImportScanStatus.Unscanned,
                "safe" => ResponseItemSecurityFileStatusPickleImportScanStatus.Safe,
                "queued" => ResponseItemSecurityFileStatusPickleImportScanStatus.Queued,
                "error" => ResponseItemSecurityFileStatusPickleImportScanStatus.Error,
                "caution" => ResponseItemSecurityFileStatusPickleImportScanStatus.Caution,
                "suspicious" => ResponseItemSecurityFileStatusPickleImportScanStatus.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusPickleImportScanStatus.Unsafe,
                _ => null,
            };
        }
    }
}