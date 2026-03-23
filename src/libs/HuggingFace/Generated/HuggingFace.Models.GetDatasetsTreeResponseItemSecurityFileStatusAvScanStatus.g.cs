
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatus
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
    public static class GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatus value)
        {
            return value switch
            {
                GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatus.Caution => "caution",
                GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatus.Error => "error",
                GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatus.Queued => "queued",
                GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatus.Safe => "safe",
                GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatus.Suspicious => "suspicious",
                GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatus.Unsafe => "unsafe",
                GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatus.Caution,
                "error" => GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatus.Error,
                "queued" => GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatus.Queued,
                "safe" => GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatus.Safe,
                "suspicious" => GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatus.Suspicious,
                "unsafe" => GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatus.Unsafe,
                "unscanned" => GetDatasetsTreeResponseItemSecurityFileStatusAvScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}