
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus
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
    public static class CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus value)
        {
            return value switch
            {
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Caution => "caution",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Error => "error",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Queued => "queued",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Safe => "safe",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Suspicious => "suspicious",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Unsafe => "unsafe",
                CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Caution,
                "error" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Error,
                "queued" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Queued,
                "safe" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Safe,
                "suspicious" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Suspicious,
                "unsafe" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Unsafe,
                "unscanned" => CreateDatasetsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}