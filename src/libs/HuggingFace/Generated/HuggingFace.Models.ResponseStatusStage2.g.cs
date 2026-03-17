
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseStatusStage2
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseStatusStage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStatusStage2 value)
        {
            return value switch
            {
                ResponseStatusStage2.Completed => "COMPLETED",
                ResponseStatusStage2.Canceled => "CANCELED",
                ResponseStatusStage2.Error => "ERROR",
                ResponseStatusStage2.Deleted => "DELETED",
                ResponseStatusStage2.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStatusStage2? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => ResponseStatusStage2.Completed,
                "CANCELED" => ResponseStatusStage2.Canceled,
                "ERROR" => ResponseStatusStage2.Error,
                "DELETED" => ResponseStatusStage2.Deleted,
                "RUNNING" => ResponseStatusStage2.Running,
                _ => null,
            };
        }
    }
}