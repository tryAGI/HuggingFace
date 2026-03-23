
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Caution,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Safe,
        /// <summary>
        /// 
        /// </summary>
        Suspicious,
        /// <summary>
        /// 
        /// </summary>
        Unsafe,
        /// <summary>
        /// 
        /// </summary>
        Unscanned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus value)
        {
            return value switch
            {
                GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Caution => "caution",
                GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Error => "error",
                GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Queued => "queued",
                GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Safe => "safe",
                GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Suspicious => "suspicious",
                GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Unsafe => "unsafe",
                GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Caution,
                "error" => GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Error,
                "queued" => GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Queued,
                "safe" => GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Safe,
                "suspicious" => GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Suspicious,
                "unsafe" => GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Unsafe,
                "unscanned" => GetModelsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}