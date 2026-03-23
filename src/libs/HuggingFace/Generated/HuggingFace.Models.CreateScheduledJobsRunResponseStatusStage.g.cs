
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateScheduledJobsRunResponseStatusStage
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateScheduledJobsRunResponseStatusStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsRunResponseStatusStage value)
        {
            return value switch
            {
                CreateScheduledJobsRunResponseStatusStage.Canceled => "CANCELED",
                CreateScheduledJobsRunResponseStatusStage.Completed => "COMPLETED",
                CreateScheduledJobsRunResponseStatusStage.Deleted => "DELETED",
                CreateScheduledJobsRunResponseStatusStage.Error => "ERROR",
                CreateScheduledJobsRunResponseStatusStage.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsRunResponseStatusStage? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => CreateScheduledJobsRunResponseStatusStage.Canceled,
                "COMPLETED" => CreateScheduledJobsRunResponseStatusStage.Completed,
                "DELETED" => CreateScheduledJobsRunResponseStatusStage.Deleted,
                "ERROR" => CreateScheduledJobsRunResponseStatusStage.Error,
                "RUNNING" => CreateScheduledJobsRunResponseStatusStage.Running,
                _ => null,
            };
        }
    }
}