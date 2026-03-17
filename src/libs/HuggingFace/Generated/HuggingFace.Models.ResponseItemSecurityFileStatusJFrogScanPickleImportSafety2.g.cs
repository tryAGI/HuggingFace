
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusJFrogScanPickleImportSafety2
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
    public static class ResponseItemSecurityFileStatusJFrogScanPickleImportSafety2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusJFrogScanPickleImportSafety2 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusJFrogScanPickleImportSafety2.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusJFrogScanPickleImportSafety2.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusJFrogScanPickleImportSafety2.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusJFrogScanPickleImportSafety2? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusJFrogScanPickleImportSafety2.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusJFrogScanPickleImportSafety2.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusJFrogScanPickleImportSafety2.Dangerous,
                _ => null,
            };
        }
    }
}