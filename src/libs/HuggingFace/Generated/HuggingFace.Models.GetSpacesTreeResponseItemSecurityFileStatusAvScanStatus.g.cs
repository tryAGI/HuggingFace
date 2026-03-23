
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus
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
    public static class GetSpacesTreeResponseItemSecurityFileStatusAvScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus value)
        {
            return value switch
            {
                GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus.Caution => "caution",
                GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus.Error => "error",
                GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus.Queued => "queued",
                GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus.Safe => "safe",
                GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus.Suspicious => "suspicious",
                GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus.Unsafe => "unsafe",
                GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus.Caution,
                "error" => GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus.Error,
                "queued" => GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus.Queued,
                "safe" => GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus.Safe,
                "suspicious" => GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus.Suspicious,
                "unsafe" => GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus.Unsafe,
                "unscanned" => GetSpacesTreeResponseItemSecurityFileStatusAvScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}