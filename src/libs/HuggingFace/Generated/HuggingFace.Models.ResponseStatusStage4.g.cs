
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseStatusStage4
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
    public static class ResponseStatusStage4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStatusStage4 value)
        {
            return value switch
            {
                ResponseStatusStage4.Completed => "COMPLETED",
                ResponseStatusStage4.Canceled => "CANCELED",
                ResponseStatusStage4.Error => "ERROR",
                ResponseStatusStage4.Deleted => "DELETED",
                ResponseStatusStage4.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStatusStage4? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => ResponseStatusStage4.Completed,
                "CANCELED" => ResponseStatusStage4.Canceled,
                "ERROR" => ResponseStatusStage4.Error,
                "DELETED" => ResponseStatusStage4.Deleted,
                "RUNNING" => ResponseStatusStage4.Running,
                _ => null,
            };
        }
    }
}