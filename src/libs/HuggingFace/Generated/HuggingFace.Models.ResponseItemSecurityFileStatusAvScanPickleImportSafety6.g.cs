
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusAvScanPickleImportSafety6
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
    public static class ResponseItemSecurityFileStatusAvScanPickleImportSafety6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusAvScanPickleImportSafety6 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusAvScanPickleImportSafety6.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusAvScanPickleImportSafety6.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusAvScanPickleImportSafety6.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusAvScanPickleImportSafety6? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusAvScanPickleImportSafety6.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusAvScanPickleImportSafety6.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusAvScanPickleImportSafety6.Dangerous,
                _ => null,
            };
        }
    }
}