
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus
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
    public static class GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus value)
        {
            return value switch
            {
                GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Caution => "caution",
                GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Error => "error",
                GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Queued => "queued",
                GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Safe => "safe",
                GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Suspicious => "suspicious",
                GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Unsafe => "unsafe",
                GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Caution,
                "error" => GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Error,
                "queued" => GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Queued,
                "safe" => GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Safe,
                "suspicious" => GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Suspicious,
                "unsafe" => GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Unsafe,
                "unscanned" => GetModelsTreeResponseItemSecurityFileStatusProtectAiScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}