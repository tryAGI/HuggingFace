
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety5
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
    public static class ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety5 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety5.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety5.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety5.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety5? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety5.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety5.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety5.Dangerous,
                _ => null,
            };
        }
    }
}