
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusStatus5
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
    public static class ResponseItemSecurityFileStatusStatus5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusStatus5 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusStatus5.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusStatus5.Safe => "safe",
                ResponseItemSecurityFileStatusStatus5.Queued => "queued",
                ResponseItemSecurityFileStatusStatus5.Error => "error",
                ResponseItemSecurityFileStatusStatus5.Caution => "caution",
                ResponseItemSecurityFileStatusStatus5.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusStatus5.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusStatus5? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusStatus5.Unscanned,
                "safe" => ResponseItemSecurityFileStatusStatus5.Safe,
                "queued" => ResponseItemSecurityFileStatusStatus5.Queued,
                "error" => ResponseItemSecurityFileStatusStatus5.Error,
                "caution" => ResponseItemSecurityFileStatusStatus5.Caution,
                "suspicious" => ResponseItemSecurityFileStatusStatus5.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusStatus5.Unsafe,
                _ => null,
            };
        }
    }
}