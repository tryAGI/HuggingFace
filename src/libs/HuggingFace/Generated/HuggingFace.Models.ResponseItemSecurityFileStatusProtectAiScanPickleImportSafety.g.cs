
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety
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
    public static class ResponseItemSecurityFileStatusProtectAiScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety.Dangerous,
                _ => null,
            };
        }
    }
}