
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatus
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
    public static class GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatus value)
        {
            return value switch
            {
                GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Caution => "caution",
                GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Error => "error",
                GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Queued => "queued",
                GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Safe => "safe",
                GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Suspicious => "suspicious",
                GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Unsafe => "unsafe",
                GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Caution,
                "error" => GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Error,
                "queued" => GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Queued,
                "safe" => GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Safe,
                "suspicious" => GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Suspicious,
                "unsafe" => GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Unsafe,
                "unscanned" => GetDatasetsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}