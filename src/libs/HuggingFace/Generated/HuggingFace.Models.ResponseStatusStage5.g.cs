
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseStatusStage5
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
    public static class ResponseStatusStage5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStatusStage5 value)
        {
            return value switch
            {
                ResponseStatusStage5.Completed => "COMPLETED",
                ResponseStatusStage5.Canceled => "CANCELED",
                ResponseStatusStage5.Error => "ERROR",
                ResponseStatusStage5.Deleted => "DELETED",
                ResponseStatusStage5.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStatusStage5? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => ResponseStatusStage5.Completed,
                "CANCELED" => ResponseStatusStage5.Canceled,
                "ERROR" => ResponseStatusStage5.Error,
                "DELETED" => ResponseStatusStage5.Deleted,
                "RUNNING" => ResponseStatusStage5.Running,
                _ => null,
            };
        }
    }
}