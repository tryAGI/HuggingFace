
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety
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
    public static class GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety value)
        {
            return value switch
            {
                GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety.Dangerous => "dangerous",
                GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety.Innocuous => "innocuous",
                GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety.Dangerous,
                "innocuous" => GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety.Innocuous,
                "suspicious" => GetSpacesTreeResponseItemSecurityFileStatusAvScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}