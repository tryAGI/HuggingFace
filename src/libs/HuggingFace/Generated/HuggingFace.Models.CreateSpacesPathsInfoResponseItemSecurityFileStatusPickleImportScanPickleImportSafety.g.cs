
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety
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
    public static class CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety value)
        {
            return value switch
            {
                CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Dangerous => "dangerous",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Innocuous => "innocuous",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Dangerous,
                "innocuous" => CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Innocuous,
                "suspicious" => CreateSpacesPathsInfoResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}