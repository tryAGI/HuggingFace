
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety
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
    public static class GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety value)
        {
            return value switch
            {
                GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety.Dangerous => "dangerous",
                GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety.Innocuous => "innocuous",
                GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety.Dangerous,
                "innocuous" => GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety.Innocuous,
                "suspicious" => GetModelsTreeResponseItemSecurityFileStatusAvScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}