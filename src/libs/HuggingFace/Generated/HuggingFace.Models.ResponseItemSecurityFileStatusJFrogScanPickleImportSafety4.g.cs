
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusJFrogScanPickleImportSafety4
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
    public static class ResponseItemSecurityFileStatusJFrogScanPickleImportSafety4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusJFrogScanPickleImportSafety4 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusJFrogScanPickleImportSafety4.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusJFrogScanPickleImportSafety4.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusJFrogScanPickleImportSafety4.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusJFrogScanPickleImportSafety4? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusJFrogScanPickleImportSafety4.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusJFrogScanPickleImportSafety4.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusJFrogScanPickleImportSafety4.Dangerous,
                _ => null,
            };
        }
    }
}