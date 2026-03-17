
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseStatusStage3
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
    public static class ResponseStatusStage3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStatusStage3 value)
        {
            return value switch
            {
                ResponseStatusStage3.Completed => "COMPLETED",
                ResponseStatusStage3.Canceled => "CANCELED",
                ResponseStatusStage3.Error => "ERROR",
                ResponseStatusStage3.Deleted => "DELETED",
                ResponseStatusStage3.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStatusStage3? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => ResponseStatusStage3.Completed,
                "CANCELED" => ResponseStatusStage3.Canceled,
                "ERROR" => ResponseStatusStage3.Error,
                "DELETED" => ResponseStatusStage3.Deleted,
                "RUNNING" => ResponseStatusStage3.Running,
                _ => null,
            };
        }
    }
}