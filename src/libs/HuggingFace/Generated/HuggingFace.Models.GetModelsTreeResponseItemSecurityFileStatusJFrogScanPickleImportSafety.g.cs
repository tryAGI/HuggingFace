
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety
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
    public static class GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety value)
        {
            return value switch
            {
                GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Dangerous => "dangerous",
                GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Innocuous => "innocuous",
                GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Dangerous,
                "innocuous" => GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Innocuous,
                "suspicious" => GetModelsTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}