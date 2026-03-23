
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety
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
    public static class GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety value)
        {
            return value switch
            {
                GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Dangerous => "dangerous",
                GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Innocuous => "innocuous",
                GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Dangerous,
                "innocuous" => GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Innocuous,
                "suspicious" => GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}