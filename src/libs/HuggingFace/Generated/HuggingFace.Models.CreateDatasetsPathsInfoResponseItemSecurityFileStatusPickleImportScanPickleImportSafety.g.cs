
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety
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
    public static class CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety value)
        {
            return value switch
            {
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Dangerous => "dangerous",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Innocuous => "innocuous",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Dangerous,
                "innocuous" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Innocuous,
                "suspicious" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}