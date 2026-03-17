
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusJFrogScanPickleImportSafety
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
    public static class ResponseItemSecurityFileStatusJFrogScanPickleImportSafetyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusJFrogScanPickleImportSafety value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Innocuous => "innocuous",
                ResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Dangerous => "dangerous",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusJFrogScanPickleImportSafety? ToEnum(string value)
        {
            return value switch
            {
                "innocuous" => ResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Innocuous,
                "suspicious" => ResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Suspicious,
                "dangerous" => ResponseItemSecurityFileStatusJFrogScanPickleImportSafety.Dangerous,
                _ => null,
            };
        }
    }
}