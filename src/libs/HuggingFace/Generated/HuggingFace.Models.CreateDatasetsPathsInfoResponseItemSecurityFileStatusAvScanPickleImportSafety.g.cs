
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety
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
    public static class CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety value)
        {
            return value switch
            {
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety.Dangerous => "dangerous",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety.Innocuous => "innocuous",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety.Dangerous,
                "innocuous" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety.Innocuous,
                "suspicious" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}