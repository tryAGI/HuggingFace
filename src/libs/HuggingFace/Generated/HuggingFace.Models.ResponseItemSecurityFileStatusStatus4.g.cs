
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemSecurityFileStatusStatus4
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
    public static class ResponseItemSecurityFileStatusStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemSecurityFileStatusStatus4 value)
        {
            return value switch
            {
                ResponseItemSecurityFileStatusStatus4.Unscanned => "unscanned",
                ResponseItemSecurityFileStatusStatus4.Safe => "safe",
                ResponseItemSecurityFileStatusStatus4.Queued => "queued",
                ResponseItemSecurityFileStatusStatus4.Error => "error",
                ResponseItemSecurityFileStatusStatus4.Caution => "caution",
                ResponseItemSecurityFileStatusStatus4.Suspicious => "suspicious",
                ResponseItemSecurityFileStatusStatus4.Unsafe => "unsafe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemSecurityFileStatusStatus4? ToEnum(string value)
        {
            return value switch
            {
                "unscanned" => ResponseItemSecurityFileStatusStatus4.Unscanned,
                "safe" => ResponseItemSecurityFileStatusStatus4.Safe,
                "queued" => ResponseItemSecurityFileStatusStatus4.Queued,
                "error" => ResponseItemSecurityFileStatusStatus4.Error,
                "caution" => ResponseItemSecurityFileStatusStatus4.Caution,
                "suspicious" => ResponseItemSecurityFileStatusStatus4.Suspicious,
                "unsafe" => ResponseItemSecurityFileStatusStatus4.Unsafe,
                _ => null,
            };
        }
    }
}