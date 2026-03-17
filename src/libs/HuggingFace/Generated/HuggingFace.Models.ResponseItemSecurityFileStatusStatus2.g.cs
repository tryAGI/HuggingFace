
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusStatus2
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
    public static class ResponseItemSecurityFileStatusStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusStatus2 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusStatus2.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusStatus2.Safe => "safe",
                ResponseItemSecurityFileStatusStatus2.Queued => "queued",
                ResponseItemSecurityFileStatusStatus2.Error => "error",
                ResponseItemSecurityFileStatusStatus2.Caution => "caution",
                ResponseItemSecurityFileStatusStatus2.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusStatus2.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusStatus2? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusStatus2.Unscanned,
                "safe" => ResponseItemSecurityFileStatusStatus2.Safe,
                "queued" => ResponseItemSecurityFileStatusStatus2.Queued,
                "error" => ResponseItemSecurityFileStatusStatus2.Error,
                "caution" => ResponseItemSecurityFileStatusStatus2.Caution,
                "suspicious" => ResponseItemSecurityFileStatusStatus2.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusStatus2.Unsafe,
                _ => null,
            };
        }
    }
}