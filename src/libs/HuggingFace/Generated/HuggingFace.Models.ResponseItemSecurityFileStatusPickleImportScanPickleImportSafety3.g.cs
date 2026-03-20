
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety3
    {
        /// <summary>
        /// 
        /// </summary>
        Innocuous,
        /// <summary>
        /// 
        /// </summary>
        Suspicious,
        /// <summary>
        /// 
        /// </summary>
        Dangerous,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety3 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety3.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety3.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety3.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety3? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety3.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety3.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety3.Dangerous,
                _ => null,
            };
        }
    }
}