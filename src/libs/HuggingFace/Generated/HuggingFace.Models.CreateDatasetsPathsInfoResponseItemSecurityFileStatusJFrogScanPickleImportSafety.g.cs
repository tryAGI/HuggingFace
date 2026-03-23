
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety
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
    public static class CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety value)
        {
            return value switch
            {
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Dangerous => "dangerous",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Innocuous => "innocuous",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Dangerous,
                "innocuous" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Innocuous,
                "suspicious" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}