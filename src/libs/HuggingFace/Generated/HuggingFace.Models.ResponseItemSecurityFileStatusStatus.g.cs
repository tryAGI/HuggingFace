
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Unscanned,
        /// <summary>
        /// 
        /// </summary>
        Safe,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Caution,
        /// <summary>
        /// 
        /// </summary>
        Suspicious,
        /// <summary>
        /// 
        /// </summary>
        Unsafe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemSecurityFileStatusStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusStatus value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusStatus.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusStatus.Safe => "safe",
                ResponseItemSecurityFileStatusStatus.Queued => "queued",
                ResponseItemSecurityFileStatusStatus.Error => "error",
                ResponseItemSecurityFileStatusStatus.Caution => "caution",
                ResponseItemSecurityFileStatusStatus.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusStatus.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusStatus? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusStatus.Unscanned,
                "safe" => ResponseItemSecurityFileStatusStatus.Safe,
                "queued" => ResponseItemSecurityFileStatusStatus.Queued,
                "error" => ResponseItemSecurityFileStatusStatus.Error,
                "caution" => ResponseItemSecurityFileStatusStatus.Caution,
                "suspicious" => ResponseItemSecurityFileStatusStatus.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusStatus.Unsafe,
                _ => null,
            };
        }
    }
}