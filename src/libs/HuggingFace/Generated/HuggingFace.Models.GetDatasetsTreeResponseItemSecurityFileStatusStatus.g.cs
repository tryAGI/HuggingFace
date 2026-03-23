
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsTreeResponseItemSecurityFileStatusStatus
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
    public static class GetDatasetsTreeResponseItemSecurityFileStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsTreeResponseItemSecurityFileStatusStatus value)
        {
            return value switch
            {
                GetDatasetsTreeResponseItemSecurityFileStatusStatus.Caution => "caution",
                GetDatasetsTreeResponseItemSecurityFileStatusStatus.Error => "error",
                GetDatasetsTreeResponseItemSecurityFileStatusStatus.Queued => "queued",
                GetDatasetsTreeResponseItemSecurityFileStatusStatus.Safe => "safe",
                GetDatasetsTreeResponseItemSecurityFileStatusStatus.Suspicious => "suspicious",
                GetDatasetsTreeResponseItemSecurityFileStatusStatus.Unsafe => "unsafe",
                GetDatasetsTreeResponseItemSecurityFileStatusStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsTreeResponseItemSecurityFileStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetDatasetsTreeResponseItemSecurityFileStatusStatus.Caution,
                "error" => GetDatasetsTreeResponseItemSecurityFileStatusStatus.Error,
                "queued" => GetDatasetsTreeResponseItemSecurityFileStatusStatus.Queued,
                "safe" => GetDatasetsTreeResponseItemSecurityFileStatusStatus.Safe,
                "suspicious" => GetDatasetsTreeResponseItemSecurityFileStatusStatus.Suspicious,
                "unsafe" => GetDatasetsTreeResponseItemSecurityFileStatusStatus.Unsafe,
                "unscanned" => GetDatasetsTreeResponseItemSecurityFileStatusStatus.Unscanned,
                _ => null,
            };
        }
    }
}