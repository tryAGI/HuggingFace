
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetSpacesTreeResponseItemSecurityFileStatusStatus
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
    public static class GetSpacesTreeResponseItemSecurityFileStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetSpacesTreeResponseItemSecurityFileStatusStatus value)
        {
            return value switch
            {
                GetSpacesTreeResponseItemSecurityFileStatusStatus.Caution => "caution",
                GetSpacesTreeResponseItemSecurityFileStatusStatus.Error => "error",
                GetSpacesTreeResponseItemSecurityFileStatusStatus.Queued => "queued",
                GetSpacesTreeResponseItemSecurityFileStatusStatus.Safe => "safe",
                GetSpacesTreeResponseItemSecurityFileStatusStatus.Suspicious => "suspicious",
                GetSpacesTreeResponseItemSecurityFileStatusStatus.Unsafe => "unsafe",
                GetSpacesTreeResponseItemSecurityFileStatusStatus.Unscanned => "unscanned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetSpacesTreeResponseItemSecurityFileStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "caution" => GetSpacesTreeResponseItemSecurityFileStatusStatus.Caution,
                "error" => GetSpacesTreeResponseItemSecurityFileStatusStatus.Error,
                "queued" => GetSpacesTreeResponseItemSecurityFileStatusStatus.Queued,
                "safe" => GetSpacesTreeResponseItemSecurityFileStatusStatus.Safe,
                "suspicious" => GetSpacesTreeResponseItemSecurityFileStatusStatus.Suspicious,
                "unsafe" => GetSpacesTreeResponseItemSecurityFileStatusStatus.Unsafe,
                "unscanned" => GetSpacesTreeResponseItemSecurityFileStatusStatus.Unscanned,
                _ => null,
            };
        }
    }
}