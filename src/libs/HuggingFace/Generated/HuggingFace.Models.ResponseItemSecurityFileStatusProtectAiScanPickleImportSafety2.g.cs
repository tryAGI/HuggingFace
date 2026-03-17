
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety2
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
    public static class ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety2 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety2.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety2.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety2.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety2? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety2.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety2.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusProtectAiScanPickleImportSafety2.Dangerous,
                _ => null,
            };
        }
    }
}