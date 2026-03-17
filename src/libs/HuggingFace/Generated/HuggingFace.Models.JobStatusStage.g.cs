
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobStatusStage
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
    public static class JobStatusStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobStatusStage value)
        {
            return value switch
            {
                JobStatusStage.Completed => "COMPLETED",
                JobStatusStage.Canceled => "CANCELED",
                JobStatusStage.Error => "ERROR",
                JobStatusStage.Deleted => "DELETED",
                JobStatusStage.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobStatusStage? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => JobStatusStage.Completed,
                "CANCELED" => JobStatusStage.Canceled,
                "ERROR" => JobStatusStage.Error,
                "DELETED" => JobStatusStage.Deleted,
                "RUNNING" => JobStatusStage.Running,
                _ => null,
            };
        }
    }
}