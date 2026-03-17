
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseStatusStage
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
    public static class ResponseStatusStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStatusStage value)
        {
            return value switch
            {
                ResponseStatusStage.Completed => "COMPLETED",
                ResponseStatusStage.Canceled => "CANCELED",
                ResponseStatusStage.Error => "ERROR",
                ResponseStatusStage.Deleted => "DELETED",
                ResponseStatusStage.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStatusStage? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => ResponseStatusStage.Completed,
                "CANCELED" => ResponseStatusStage.Canceled,
                "ERROR" => ResponseStatusStage.Error,
                "DELETED" => ResponseStatusStage.Deleted,
                "RUNNING" => ResponseStatusStage.Running,
                _ => null,
            };
        }
    }
}