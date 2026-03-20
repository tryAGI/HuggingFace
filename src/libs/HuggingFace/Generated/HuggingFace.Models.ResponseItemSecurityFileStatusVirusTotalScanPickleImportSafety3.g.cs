
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety3
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
    public static class ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety3 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety3.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety3.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety3.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety3? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety3.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety3.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety3.Dangerous,
                _ => null,
            };
        }
    }
}