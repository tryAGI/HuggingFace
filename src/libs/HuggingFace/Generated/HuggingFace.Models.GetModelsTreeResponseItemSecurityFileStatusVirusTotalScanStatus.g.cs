
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus
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
    public static class GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus value)
        {
            return value switch
            {
                GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Caution => "caution",
                GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Error => "error",
                GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Queued => "queued",
                GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Safe => "safe",
                GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Suspicious => "suspicious",
                GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Unsafe => "unsafe",
                GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Caution,
                "error" => GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Error,
                "queued" => GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Queued,
                "safe" => GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Safe,
                "suspicious" => GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Suspicious,
                "unsafe" => GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Unsafe,
                "unscanned" => GetModelsTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}