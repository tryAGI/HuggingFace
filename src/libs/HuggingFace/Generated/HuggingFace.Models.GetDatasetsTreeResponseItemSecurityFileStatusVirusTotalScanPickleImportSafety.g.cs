
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety
    {
        /// <summary>
        /// 
        /// </summary>
        Dangerous,
        /// <summary>
        /// 
        /// </summary>
        Innocuous,
        /// <summary>
        /// 
        /// </summary>
        Suspicious,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety value)
        {
            return value switch
            {
                GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Dangerous => "dangerous",
                GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Innocuous => "innocuous",
                GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Dangerous,
                "innocuous" => GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Innocuous,
                "suspicious" => GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}