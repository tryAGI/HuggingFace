
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety6
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
    public static class ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety6 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety6.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety6.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety6.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety6? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety6.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety6.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety6.Dangerous,
                _ => null,
            };
        }
    }
}