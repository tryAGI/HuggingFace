
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusJFrogScanPickleImportSafety5
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
    public static class ResponseItemSecurityFileStatusJFrogScanPickleImportSafety5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusJFrogScanPickleImportSafety5 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusJFrogScanPickleImportSafety5.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusJFrogScanPickleImportSafety5.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusJFrogScanPickleImportSafety5.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusJFrogScanPickleImportSafety5? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusJFrogScanPickleImportSafety5.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusJFrogScanPickleImportSafety5.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusJFrogScanPickleImportSafety5.Dangerous,
                _ => null,
            };
        }
    }
}