
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusJFrogScanPickleImportSafety3
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
    public static class ResponseItemSecurityFileStatusJFrogScanPickleImportSafety3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusJFrogScanPickleImportSafety3 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusJFrogScanPickleImportSafety3.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusJFrogScanPickleImportSafety3.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusJFrogScanPickleImportSafety3.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusJFrogScanPickleImportSafety3? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusJFrogScanPickleImportSafety3.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusJFrogScanPickleImportSafety3.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusJFrogScanPickleImportSafety3.Dangerous,
                _ => null,
            };
        }
    }
}