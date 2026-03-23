
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety
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
    public static class CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety value)
        {
            return value switch
            {
                CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Dangerous => "dangerous",
                CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Innocuous => "innocuous",
                CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Dangerous,
                "innocuous" => CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Innocuous,
                "suspicious" => CreateModelsPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}