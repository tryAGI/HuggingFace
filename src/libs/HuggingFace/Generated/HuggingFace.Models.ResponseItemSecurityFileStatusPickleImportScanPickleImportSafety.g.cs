
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety
    {
        /// <summary>
        /// 
        /// </summary>
        Innocuous,
        /// <summary>
        /// 
        /// </summary>
        Suspicious,
        /// <summary>
        /// 
        /// </summary>
        Dangerous,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemSecurityFileStatusPickleImportScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety.Dangerous,
                _ => null,
            };
        }
    }
}