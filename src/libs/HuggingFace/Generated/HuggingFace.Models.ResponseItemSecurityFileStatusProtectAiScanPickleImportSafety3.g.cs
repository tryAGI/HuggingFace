
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety3
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
    public static class ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety3 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety3.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety3.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety3.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety3? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety3.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety3.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety3.Dangerous,
                _ => null,
            };
        }
    }
}