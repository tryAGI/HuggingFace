
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsResponseStatusStage
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
    public static class GetJobsResponseStatusStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsResponseStatusStage value)
        {
            return value switch
            {
                GetJobsResponseStatusStage.Canceled => "CANCELED",
                GetJobsResponseStatusStage.Completed => "COMPLETED",
                GetJobsResponseStatusStage.Deleted => "DELETED",
                GetJobsResponseStatusStage.Error => "ERROR",
                GetJobsResponseStatusStage.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsResponseStatusStage? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => GetJobsResponseStatusStage.Canceled,
                "COMPLETED" => GetJobsResponseStatusStage.Completed,
                "DELETED" => GetJobsResponseStatusStage.Deleted,
                "ERROR" => GetJobsResponseStatusStage.Error,
                "RUNNING" => GetJobsResponseStatusStage.Running,
                _ => null,
            };
        }
    }
}