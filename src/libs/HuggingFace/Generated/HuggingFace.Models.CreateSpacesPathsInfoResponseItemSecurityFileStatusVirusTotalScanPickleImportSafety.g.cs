
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety
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
    public static class CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety value)
        {
            return value switch
            {
                CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Dangerous => "dangerous",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Innocuous => "innocuous",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Dangerous,
                "innocuous" => CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Innocuous,
                "suspicious" => CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}