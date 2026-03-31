
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
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Scheduling,
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
                JobStatusStage.Canceled => "CANCELED",
                JobStatusStage.Completed => "COMPLETED",
                JobStatusStage.Deleted => "DELETED",
                JobStatusStage.Error => "ERROR",
                JobStatusStage.Running => "RUNNING",
                JobStatusStage.Scheduling => "SCHEDULING",
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
                "CANCELED" => JobStatusStage.Canceled,
                "COMPLETED" => JobStatusStage.Completed,
                "DELETED" => JobStatusStage.Deleted,
                "ERROR" => JobStatusStage.Error,
                "RUNNING" => JobStatusStage.Running,
                "SCHEDULING" => JobStatusStage.Scheduling,
                _ => null,
            };
        }
    }
}