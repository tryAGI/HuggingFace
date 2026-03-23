
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety
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
    public static class GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety value)
        {
            return value switch
            {
                GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Dangerous => "dangerous",
                GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Innocuous => "innocuous",
                GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Dangerous,
                "innocuous" => GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Innocuous,
                "suspicious" => GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}