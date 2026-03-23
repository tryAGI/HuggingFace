
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety
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
    public static class GetDatasetsTreeResponseItemSecurityFileStatusAvScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety value)
        {
            return value switch
            {
                GetDatasetsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety.Dangerous => "dangerous",
                GetDatasetsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety.Innocuous => "innocuous",
                GetDatasetsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => GetDatasetsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety.Dangerous,
                "innocuous" => GetDatasetsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety.Innocuous,
                "suspicious" => GetDatasetsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}