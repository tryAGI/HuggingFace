
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusAvScanPickleImportSafety2
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
    public static class ResponseItemSecurityFileStatusAvScanPickleImportSafety2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusAvScanPickleImportSafety2 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusAvScanPickleImportSafety2.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusAvScanPickleImportSafety2.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusAvScanPickleImportSafety2.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusAvScanPickleImportSafety2? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusAvScanPickleImportSafety2.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusAvScanPickleImportSafety2.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusAvScanPickleImportSafety2.Dangerous,
                _ => null,
            };
        }
    }
}