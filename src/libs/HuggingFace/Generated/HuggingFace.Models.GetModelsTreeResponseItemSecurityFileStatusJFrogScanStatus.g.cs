
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus
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
    public static class GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus value)
        {
            return value switch
            {
                GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus.Caution => "caution",
                GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus.Error => "error",
                GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus.Queued => "queued",
                GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus.Safe => "safe",
                GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus.Suspicious => "suspicious",
                GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus.Unsafe => "unsafe",
                GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus.Caution,
                "error" => GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus.Error,
                "queued" => GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus.Queued,
                "safe" => GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus.Safe,
                "suspicious" => GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus.Suspicious,
                "unsafe" => GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus.Unsafe,
                "unscanned" => GetModelsTreeResponseItemSecurityFileStatusJFrogScanStatus.Unscanned,
                _ => null,
            };
        }
    }
}