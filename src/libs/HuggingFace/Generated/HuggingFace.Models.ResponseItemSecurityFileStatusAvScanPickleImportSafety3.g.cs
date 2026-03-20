
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusAvScanPickleImportSafety3
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
    public static class ResponseItemSecurityFileStatusAvScanPickleImportSafety3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusAvScanPickleImportSafety3 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusAvScanPickleImportSafety3.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusAvScanPickleImportSafety3.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusAvScanPickleImportSafety3.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusAvScanPickleImportSafety3? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusAvScanPickleImportSafety3.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusAvScanPickleImportSafety3.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusAvScanPickleImportSafety3.Dangerous,
                _ => null,
            };
        }
    }
}