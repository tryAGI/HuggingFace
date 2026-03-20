
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety4
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
    public static class ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety4 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety4.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety4.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety4.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety4? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety4.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety4.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety4.Dangerous,
                _ => null,
            };
        }
    }
}