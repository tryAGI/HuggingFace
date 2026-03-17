
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemStatusStage
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
    public static class ResponseItemStatusStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemStatusStage value)
        {
            return value switch
            {
                ResponseItemStatusStage.Completed => "COMPLETED",
                ResponseItemStatusStage.Canceled => "CANCELED",
                ResponseItemStatusStage.Error => "ERROR",
                ResponseItemStatusStage.Deleted => "DELETED",
                ResponseItemStatusStage.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemStatusStage? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => ResponseItemStatusStage.Completed,
                "CANCELED" => ResponseItemStatusStage.Canceled,
                "ERROR" => ResponseItemStatusStage.Error,
                "DELETED" => ResponseItemStatusStage.Deleted,
                "RUNNING" => ResponseItemStatusStage.Running,
                _ => null,
            };
        }
    }
}