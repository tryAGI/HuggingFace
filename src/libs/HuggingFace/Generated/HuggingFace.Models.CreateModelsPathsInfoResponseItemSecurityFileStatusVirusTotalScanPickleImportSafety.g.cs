
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety
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
    public static class CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety value)
        {
            return value switch
            {
                CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Dangerous => "dangerous",
                CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Innocuous => "innocuous",
                CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Dangerous,
                "innocuous" => CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Innocuous,
                "suspicious" => CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}