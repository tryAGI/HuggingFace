
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus
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
    public static class GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus value)
        {
            return value switch
            {
                GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus.Caution => "caution",
                GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus.Error => "error",
                GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus.Queued => "queued",
                GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus.Safe => "safe",
                GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus.Suspicious => "suspicious",
                GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus.Unsafe => "unsafe",
                GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus.Caution,
                "error" => GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus.Error,
                "queued" => GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus.Queued,
                "safe" => GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus.Safe,
                "suspicious" => GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus.Suspicious,
                "unsafe" => GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus.Unsafe,
                "unscanned" => GetSpacesTreeResponseItemSecurityFileStatusProtectAiScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}