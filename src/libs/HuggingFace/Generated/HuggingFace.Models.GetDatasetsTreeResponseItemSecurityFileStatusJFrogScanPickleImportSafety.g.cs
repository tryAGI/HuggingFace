
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety
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
    public static class GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety value)
        {
            return value switch
            {
                GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Dangerous => "dangerous",
                GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Innocuous => "innocuous",
                GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Dangerous,
                "innocuous" => GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Innocuous,
                "suspicious" => GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}