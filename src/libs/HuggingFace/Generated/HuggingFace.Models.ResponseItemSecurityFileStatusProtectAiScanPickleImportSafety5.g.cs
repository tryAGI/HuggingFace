
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety5
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
    public static class ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety5 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety5.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety5.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety5.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety5? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety5.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety5.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety5.Dangerous,
                _ => null,
            };
        }
    }
}