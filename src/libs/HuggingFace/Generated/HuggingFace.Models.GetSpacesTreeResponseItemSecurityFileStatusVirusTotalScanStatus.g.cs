
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus
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
    public static class GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus value)
        {
            return value switch
            {
                GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Caution => "caution",
                GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Error => "error",
                GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Queued => "queued",
                GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Safe => "safe",
                GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Suspicious => "suspicious",
                GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Unsafe => "unsafe",
                GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Caution,
                "error" => GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Error,
                "queued" => GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Queued,
                "safe" => GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Safe,
                "suspicious" => GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Suspicious,
                "unsafe" => GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Unsafe,
                "unscanned" => GetSpacesTreeResponseItemSecurityFileStatusVirusTotalScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}