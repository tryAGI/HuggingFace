
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety
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
    public static class CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety value)
        {
            return value switch
            {
                CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Dangerous => "dangerous",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Innocuous => "innocuous",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Dangerous,
                "innocuous" => CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Innocuous,
                "suspicious" => CreateSpacesPathsInfoResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}