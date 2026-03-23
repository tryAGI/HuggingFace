
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety
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
    public static class CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety value)
        {
            return value switch
            {
                CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety.Dangerous => "dangerous",
                CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety.Innocuous => "innocuous",
                CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety.Dangerous,
                "innocuous" => CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety.Innocuous,
                "suspicious" => CreateModelsPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}