
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatus
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
    public static class GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatus value)
        {
            return value switch
            {
                GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Caution => "caution",
                GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Error => "error",
                GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Queued => "queued",
                GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Safe => "safe",
                GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Suspicious => "suspicious",
                GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Unsafe => "unsafe",
                GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Caution,
                "error" => GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Error,
                "queued" => GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Queued,
                "safe" => GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Safe,
                "suspicious" => GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Suspicious,
                "unsafe" => GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Unsafe,
                "unscanned" => GetDatasetsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}