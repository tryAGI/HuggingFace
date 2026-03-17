
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety
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
    public static class ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Dangerous,
                _ => null,
            };
        }
    }
}