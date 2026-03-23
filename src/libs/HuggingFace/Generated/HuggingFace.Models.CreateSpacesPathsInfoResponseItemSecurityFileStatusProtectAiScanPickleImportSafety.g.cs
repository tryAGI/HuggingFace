
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety
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
    public static class CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety value)
        {
            return value switch
            {
                CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Dangerous => "dangerous",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Innocuous => "innocuous",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Dangerous,
                "innocuous" => CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Innocuous,
                "suspicious" => CreateSpacesPathsInfoResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}