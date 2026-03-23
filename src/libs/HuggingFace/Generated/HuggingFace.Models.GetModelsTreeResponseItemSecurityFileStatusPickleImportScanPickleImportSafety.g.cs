
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety
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
    public static class GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety value)
        {
            return value switch
            {
                GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Dangerous => "dangerous",
                GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Innocuous => "innocuous",
                GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Dangerous,
                "innocuous" => GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Innocuous,
                "suspicious" => GetModelsTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}