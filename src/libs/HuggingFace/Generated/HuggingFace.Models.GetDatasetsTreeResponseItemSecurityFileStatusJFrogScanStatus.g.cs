
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatus
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
    public static class GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatus value)
        {
            return value switch
            {
                GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatus.Caution => "caution",
                GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatus.Error => "error",
                GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatus.Queued => "queued",
                GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatus.Safe => "safe",
                GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatus.Suspicious => "suspicious",
                GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatus.Unsafe => "unsafe",
                GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatus.Caution,
                "error" => GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatus.Error,
                "queued" => GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatus.Queued,
                "safe" => GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatus.Safe,
                "suspicious" => GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatus.Suspicious,
                "unsafe" => GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatus.Unsafe,
                "unscanned" => GetDatasetsTreeResponseItemSecurityFileStatusJFrogScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}