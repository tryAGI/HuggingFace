
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety
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
    public static class CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety value)
        {
            return value switch
            {
                CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety.Dangerous => "dangerous",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety.Innocuous => "innocuous",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety.Dangerous,
                "innocuous" => CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety.Innocuous,
                "suspicious" => CreateSpacesPathsInfoResponseItemSecurityFileStatusAvScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}