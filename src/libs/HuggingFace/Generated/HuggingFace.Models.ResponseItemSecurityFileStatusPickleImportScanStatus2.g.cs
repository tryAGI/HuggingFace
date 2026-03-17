
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusPickleImportScanStatus2
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
    public static class ResponseItemSecurityFileStatusPickleImportScanStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusPickleImportScanStatus2 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusPickleImportScanStatus2.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusPickleImportScanStatus2.Safe => "safe",
                ResponseItemSecurityFileStatusPickleImportScanStatus2.Queued => "queued",
                ResponseItemSecurityFileStatusPickleImportScanStatus2.Error => "error",
                ResponseItemSecurityFileStatusPickleImportScanStatus2.Caution => "caution",
                ResponseItemSecurityFileStatusPickleImportScanStatus2.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusPickleImportScanStatus2.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusPickleImportScanStatus2? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusPickleImportScanStatus2.Unscanned,
                "safe" => ResponseItemSecurityFileStatusPickleImportScanStatus2.Safe,
                "queued" => ResponseItemSecurityFileStatusPickleImportScanStatus2.Queued,
                "error" => ResponseItemSecurityFileStatusPickleImportScanStatus2.Error,
                "caution" => ResponseItemSecurityFileStatusPickleImportScanStatus2.Caution,
                "suspicious" => ResponseItemSecurityFileStatusPickleImportScanStatus2.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusPickleImportScanStatus2.Unsafe,
                _ => null,
            };
        }
    }
}