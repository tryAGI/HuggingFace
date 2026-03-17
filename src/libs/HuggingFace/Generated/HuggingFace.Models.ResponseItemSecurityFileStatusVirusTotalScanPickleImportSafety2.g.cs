
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety2
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
    public static class ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety2 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety2.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety2.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety2.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety2? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety2.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety2.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety2.Dangerous,
                _ => null,
            };
        }
    }
}