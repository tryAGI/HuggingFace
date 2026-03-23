
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus
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
    public static class GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus value)
        {
            return value switch
            {
                GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus.Caution => "caution",
                GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus.Error => "error",
                GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus.Queued => "queued",
                GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus.Safe => "safe",
                GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus.Suspicious => "suspicious",
                GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus.Unsafe => "unsafe",
                GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus.Caution,
                "error" => GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus.Error,
                "queued" => GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus.Queued,
                "safe" => GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus.Safe,
                "suspicious" => GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus.Suspicious,
                "unsafe" => GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus.Unsafe,
                "unscanned" => GetSpacesTreeResponseItemSecurityFileStatusJFrogScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}