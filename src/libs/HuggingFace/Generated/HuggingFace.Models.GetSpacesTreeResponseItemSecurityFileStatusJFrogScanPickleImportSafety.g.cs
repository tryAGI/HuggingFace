
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety
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
    public static class GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety value)
        {
            return value switch
            {
                GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Dangerous => "dangerous",
                GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Innocuous => "innocuous",
                GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Suspicious => "suspicious",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "dangerous" => GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Dangerous,
                "innocuous" => GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Innocuous,
                "suspicious" => GetSpacesTreeResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Suspicious,
                _ => null,
            };
        }
    }
}