
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusAvScanPickleImportSafety5
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
    public static class ResponseItemSecurityFileStatusAvScanPickleImportSafety5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusAvScanPickleImportSafety5 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusAvScanPickleImportSafety5.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusAvScanPickleImportSafety5.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusAvScanPickleImportSafety5.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusAvScanPickleImportSafety5? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusAvScanPickleImportSafety5.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusAvScanPickleImportSafety5.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusAvScanPickleImportSafety5.Dangerous,
                _ => null,
            };
        }
    }
}