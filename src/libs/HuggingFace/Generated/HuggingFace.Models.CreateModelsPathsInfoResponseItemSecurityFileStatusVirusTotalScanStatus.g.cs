
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus
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
    public static class CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus value)
        {
            return value switch
            {
                CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Caution => "caution",
                CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Error => "error",
                CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Queued => "queued",
                CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Safe => "safe",
                CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Suspicious => "suspicious",
                CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Unsafe => "unsafe",
                CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Caution,
                "error" => CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Error,
                "queued" => CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Queued,
                "safe" => CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Safe,
                "suspicious" => CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Suspicious,
                "unsafe" => CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Unsafe,
                "unscanned" => CreateModelsPathsInfoResponseItemSecurityFileStatusVirusTotalScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}