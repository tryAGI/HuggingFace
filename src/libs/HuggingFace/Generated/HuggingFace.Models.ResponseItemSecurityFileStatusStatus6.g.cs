
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusStatus6
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
    public static class ResponseItemSecurityFileStatusStatus6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusStatus6 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusStatus6.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusStatus6.Safe => "safe",
                ResponseItemSecurityFileStatusStatus6.Queued => "queued",
                ResponseItemSecurityFileStatusStatus6.Error => "error",
                ResponseItemSecurityFileStatusStatus6.Caution => "caution",
                ResponseItemSecurityFileStatusStatus6.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusStatus6.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusStatus6? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusStatus6.Unscanned,
                "safe" => ResponseItemSecurityFileStatusStatus6.Safe,
                "queued" => ResponseItemSecurityFileStatusStatus6.Queued,
                "error" => ResponseItemSecurityFileStatusStatus6.Error,
                "caution" => ResponseItemSecurityFileStatusStatus6.Caution,
                "suspicious" => ResponseItemSecurityFileStatusStatus6.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusStatus6.Unsafe,
                _ => null,
            };
        }
    }
}