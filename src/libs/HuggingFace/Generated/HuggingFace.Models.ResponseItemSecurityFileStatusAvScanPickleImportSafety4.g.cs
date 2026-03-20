
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusAvScanPickleImportSafety4
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
    public static class ResponseItemSecurityFileStatusAvScanPickleImportSafety4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusAvScanPickleImportSafety4 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusAvScanPickleImportSafety4.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusAvScanPickleImportSafety4.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusAvScanPickleImportSafety4.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusAvScanPickleImportSafety4? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusAvScanPickleImportSafety4.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusAvScanPickleImportSafety4.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusAvScanPickleImportSafety4.Dangerous,
                _ => null,
            };
        }
    }
}