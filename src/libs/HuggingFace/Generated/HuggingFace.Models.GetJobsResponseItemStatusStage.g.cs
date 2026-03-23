
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsResponseItemStatusStage
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
    public static class GetJobsResponseItemStatusStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsResponseItemStatusStage value)
        {
            return value switch
            {
                GetJobsResponseItemStatusStage.Canceled => "CANCELED",
                GetJobsResponseItemStatusStage.Completed => "COMPLETED",
                GetJobsResponseItemStatusStage.Deleted => "DELETED",
                GetJobsResponseItemStatusStage.Error => "ERROR",
                GetJobsResponseItemStatusStage.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsResponseItemStatusStage? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => GetJobsResponseItemStatusStage.Canceled,
                "COMPLETED" => GetJobsResponseItemStatusStage.Completed,
                "DELETED" => GetJobsResponseItemStatusStage.Deleted,
                "ERROR" => GetJobsResponseItemStatusStage.Error,
                "RUNNING" => GetJobsResponseItemStatusStage.Running,
                _ => null,
            };
        }
    }
}