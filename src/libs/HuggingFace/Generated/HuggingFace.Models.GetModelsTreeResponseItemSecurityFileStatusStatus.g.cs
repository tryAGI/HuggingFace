
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelsTreeResponseItemSecurityFileStatusStatus
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
    public static class GetModelsTreeResponseItemSecurityFileStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsTreeResponseItemSecurityFileStatusStatus value)
        {
            return value switch
            {
                GetModelsTreeResponseItemSecurityFileStatusStatus.Caution => "caution",
                GetModelsTreeResponseItemSecurityFileStatusStatus.Error => "error",
                GetModelsTreeResponseItemSecurityFileStatusStatus.Queued => "queued",
                GetModelsTreeResponseItemSecurityFileStatusStatus.Safe => "safe",
                GetModelsTreeResponseItemSecurityFileStatusStatus.Suspicious => "suspicious",
                GetModelsTreeResponseItemSecurityFileStatusStatus.Unsafe => "unsafe",
                GetModelsTreeResponseItemSecurityFileStatusStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsTreeResponseItemSecurityFileStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetModelsTreeResponseItemSecurityFileStatusStatus.Caution,
                "error" => GetModelsTreeResponseItemSecurityFileStatusStatus.Error,
                "queued" => GetModelsTreeResponseItemSecurityFileStatusStatus.Queued,
                "safe" => GetModelsTreeResponseItemSecurityFileStatusStatus.Safe,
                "suspicious" => GetModelsTreeResponseItemSecurityFileStatusStatus.Suspicious,
                "unsafe" => GetModelsTreeResponseItemSecurityFileStatusStatus.Unsafe,
                "unscanned" => GetModelsTreeResponseItemSecurityFileStatusStatus.Unscanned,
                _ => null,
            };
        }
    }
}