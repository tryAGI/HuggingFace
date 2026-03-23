
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety
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
    public static class CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety value)
        {
            return value switch
            {
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Dangerous => "dangerous",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Innocuous => "innocuous",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Dangerous,
                "innocuous" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Innocuous,
                "suspicious" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}