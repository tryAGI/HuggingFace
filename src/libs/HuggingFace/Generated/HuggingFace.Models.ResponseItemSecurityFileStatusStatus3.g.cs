
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusStatus3
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
    public static class ResponseItemSecurityFileStatusStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusStatus3 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusStatus3.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusStatus3.Safe => "safe",
                ResponseItemSecurityFileStatusStatus3.Queued => "queued",
                ResponseItemSecurityFileStatusStatus3.Error => "error",
                ResponseItemSecurityFileStatusStatus3.Caution => "caution",
                ResponseItemSecurityFileStatusStatus3.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusStatus3.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusStatus3? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusStatus3.Unscanned,
                "safe" => ResponseItemSecurityFileStatusStatus3.Safe,
                "queued" => ResponseItemSecurityFileStatusStatus3.Queued,
                "error" => ResponseItemSecurityFileStatusStatus3.Error,
                "caution" => ResponseItemSecurityFileStatusStatus3.Caution,
                "suspicious" => ResponseItemSecurityFileStatusStatus3.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusStatus3.Unsafe,
                _ => null,
            };
        }
    }
}