
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety
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
    public static class GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety value)
        {
            return value switch
            {
                GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Dangerous => "dangerous",
                GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Innocuous => "innocuous",
                GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Dangerous,
                "innocuous" => GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Innocuous,
                "suspicious" => GetSpacesTreeResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}