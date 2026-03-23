
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety
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
    public static class GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety value)
        {
            return value switch
            {
                GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Dangerous => "dangerous",
                GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Innocuous => "innocuous",
                GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Dangerous,
                "innocuous" => GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Innocuous,
                "suspicious" => GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}