
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusPickleImportScanStatus4
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
    public static class ResponseItemSecurityFileStatusPickleImportScanStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusPickleImportScanStatus4 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusPickleImportScanStatus4.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusPickleImportScanStatus4.Safe => "safe",
                ResponseItemSecurityFileStatusPickleImportScanStatus4.Queued => "queued",
                ResponseItemSecurityFileStatusPickleImportScanStatus4.Error => "error",
                ResponseItemSecurityFileStatusPickleImportScanStatus4.Caution => "caution",
                ResponseItemSecurityFileStatusPickleImportScanStatus4.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusPickleImportScanStatus4.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusPickleImportScanStatus4? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusPickleImportScanStatus4.Unscanned,
                "safe" => ResponseItemSecurityFileStatusPickleImportScanStatus4.Safe,
                "queued" => ResponseItemSecurityFileStatusPickleImportScanStatus4.Queued,
                "error" => ResponseItemSecurityFileStatusPickleImportScanStatus4.Error,
                "caution" => ResponseItemSecurityFileStatusPickleImportScanStatus4.Caution,
                "suspicious" => ResponseItemSecurityFileStatusPickleImportScanStatus4.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusPickleImportScanStatus4.Unsafe,
                _ => null,
            };
        }
    }
}