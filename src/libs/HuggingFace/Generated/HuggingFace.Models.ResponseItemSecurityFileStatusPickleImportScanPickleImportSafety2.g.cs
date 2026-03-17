
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety2
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
    public static class ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety2 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety2.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety2.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety2.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety2? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety2.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety2.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusPickleImportScanPickleImportSafety2.Dangerous,
                _ => null,
            };
        }
    }
}