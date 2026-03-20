
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety5
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
    public static class ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety5 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety5.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety5.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety5.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety5? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety5.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety5.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety5.Dangerous,
                _ => null,
            };
        }
    }
}