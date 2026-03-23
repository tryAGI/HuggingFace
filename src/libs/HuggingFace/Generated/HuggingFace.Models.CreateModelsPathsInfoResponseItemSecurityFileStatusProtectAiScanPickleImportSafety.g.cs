
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety
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
    public static class CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety value)
        {
            return value switch
            {
                CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Dangerous => "dangerous",
                CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Innocuous => "innocuous",
                CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Dangerous,
                "innocuous" => CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Innocuous,
                "suspicious" => CreateModelsPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}