
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusPickleImportScanStatus6
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
    public static class ResponseItemSecurityFileStatusPickleImportScanStatus6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusPickleImportScanStatus6 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusPickleImportScanStatus6.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusPickleImportScanStatus6.Safe => "safe",
                ResponseItemSecurityFileStatusPickleImportScanStatus6.Queued => "queued",
                ResponseItemSecurityFileStatusPickleImportScanStatus6.Error => "error",
                ResponseItemSecurityFileStatusPickleImportScanStatus6.Caution => "caution",
                ResponseItemSecurityFileStatusPickleImportScanStatus6.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusPickleImportScanStatus6.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusPickleImportScanStatus6? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusPickleImportScanStatus6.Unscanned,
                "safe" => ResponseItemSecurityFileStatusPickleImportScanStatus6.Safe,
                "queued" => ResponseItemSecurityFileStatusPickleImportScanStatus6.Queued,
                "error" => ResponseItemSecurityFileStatusPickleImportScanStatus6.Error,
                "caution" => ResponseItemSecurityFileStatusPickleImportScanStatus6.Caution,
                "suspicious" => ResponseItemSecurityFileStatusPickleImportScanStatus6.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusPickleImportScanStatus6.Unsafe,
                _ => null,
            };
        }
    }
}