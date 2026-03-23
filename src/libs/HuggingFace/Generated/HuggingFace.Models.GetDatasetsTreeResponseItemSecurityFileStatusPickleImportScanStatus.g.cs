
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatus
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
    public static class GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatus value)
        {
            return value switch
            {
                GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Caution => "caution",
                GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Error => "error",
                GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Queued => "queued",
                GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Safe => "safe",
                GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Suspicious => "suspicious",
                GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Unsafe => "unsafe",
                GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Caution,
                "error" => GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Error,
                "queued" => GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Queued,
                "safe" => GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Safe,
                "suspicious" => GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Suspicious,
                "unsafe" => GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Unsafe,
                "unscanned" => GetDatasetsTreeResponseItemSecurityFileStatusPickleImportScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}