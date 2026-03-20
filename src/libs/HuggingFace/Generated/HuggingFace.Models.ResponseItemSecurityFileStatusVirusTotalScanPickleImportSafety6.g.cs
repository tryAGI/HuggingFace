
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety6
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
    public static class ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety6 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety6.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety6.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety6.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety6? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety6.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety6.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety6.Dangerous,
                _ => null,
            };
        }
    }
}