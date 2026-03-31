
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsResponseStatusStage
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
    public static class CreateJobsResponseStatusStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsResponseStatusStage value)
        {
            return value switch
            {
                CreateJobsResponseStatusStage.Canceled => "CANCELED",
                CreateJobsResponseStatusStage.Completed => "COMPLETED",
                CreateJobsResponseStatusStage.Deleted => "DELETED",
                CreateJobsResponseStatusStage.Error => "ERROR",
                CreateJobsResponseStatusStage.Running => "RUNNING",
                CreateJobsResponseStatusStage.Scheduling => "SCHEDULING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsResponseStatusStage? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => CreateJobsResponseStatusStage.Canceled,
                "COMPLETED" => CreateJobsResponseStatusStage.Completed,
                "DELETED" => CreateJobsResponseStatusStage.Deleted,
                "ERROR" => CreateJobsResponseStatusStage.Error,
                "RUNNING" => CreateJobsResponseStatusStage.Running,
                "SCHEDULING" => CreateJobsResponseStatusStage.Scheduling,
                _ => null,
            };
        }
    }
}