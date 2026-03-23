
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus
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
    public static class CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus value)
        {
            return value switch
            {
                CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Caution => "caution",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Error => "error",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Queued => "queued",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Safe => "safe",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Suspicious => "suspicious",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Unsafe => "unsafe",
                CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Caution,
                "error" => CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Error,
                "queued" => CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Queued,
                "safe" => CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Safe,
                "suspicious" => CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Suspicious,
                "unsafe" => CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Unsafe,
                "unscanned" => CreateSpacesPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}