
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelsTreeResponseItemSecurityFileStatusAvScanStatus
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
    public static class GetModelsTreeResponseItemSecurityFileStatusAvScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsTreeResponseItemSecurityFileStatusAvScanStatus value)
        {
            return value switch
            {
                GetModelsTreeResponseItemSecurityFileStatusAvScanStatus.Caution => "caution",
                GetModelsTreeResponseItemSecurityFileStatusAvScanStatus.Error => "error",
                GetModelsTreeResponseItemSecurityFileStatusAvScanStatus.Queued => "queued",
                GetModelsTreeResponseItemSecurityFileStatusAvScanStatus.Safe => "safe",
                GetModelsTreeResponseItemSecurityFileStatusAvScanStatus.Suspicious => "suspicious",
                GetModelsTreeResponseItemSecurityFileStatusAvScanStatus.Unsafe => "unsafe",
                GetModelsTreeResponseItemSecurityFileStatusAvScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsTreeResponseItemSecurityFileStatusAvScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetModelsTreeResponseItemSecurityFileStatusAvScanStatus.Caution,
                "error" => GetModelsTreeResponseItemSecurityFileStatusAvScanStatus.Error,
                "queued" => GetModelsTreeResponseItemSecurityFileStatusAvScanStatus.Queued,
                "safe" => GetModelsTreeResponseItemSecurityFileStatusAvScanStatus.Safe,
                "suspicious" => GetModelsTreeResponseItemSecurityFileStatusAvScanStatus.Suspicious,
                "unsafe" => GetModelsTreeResponseItemSecurityFileStatusAvScanStatus.Unsafe,
                "unscanned" => GetModelsTreeResponseItemSecurityFileStatusAvScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}