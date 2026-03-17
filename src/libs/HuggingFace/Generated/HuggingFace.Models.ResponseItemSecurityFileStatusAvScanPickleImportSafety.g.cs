
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusAvScanPickleImportSafety
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
    public static class ResponseItemSecurityFileStatusAvScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusAvScanPickleImportSafety value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusAvScanPickleImportSafety.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusAvScanPickleImportSafety.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusAvScanPickleImportSafety.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusAvScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusAvScanPickleImportSafety.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusAvScanPickleImportSafety.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusAvScanPickleImportSafety.Dangerous,
                _ => null,
            };
        }
    }
}