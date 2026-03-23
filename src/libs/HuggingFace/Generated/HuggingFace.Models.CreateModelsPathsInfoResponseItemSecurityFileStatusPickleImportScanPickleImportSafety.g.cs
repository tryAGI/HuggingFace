
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety
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
    public static class CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety value)
        {
            return value switch
            {
                CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Dangerous => "dangerous",
                CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Innocuous => "innocuous",
                CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Dangerous,
                "innocuous" => CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Innocuous,
                "suspicious" => CreateModelsPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}