
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsCountStage
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
    public static class GetJobsCountStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsCountStage value)
        {
            return value switch
            {
                GetJobsCountStage.Canceled => "CANCELED",
                GetJobsCountStage.Completed => "COMPLETED",
                GetJobsCountStage.Deleted => "DELETED",
                GetJobsCountStage.Error => "ERROR",
                GetJobsCountStage.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsCountStage? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => GetJobsCountStage.Canceled,
                "COMPLETED" => GetJobsCountStage.Completed,
                "DELETED" => GetJobsCountStage.Deleted,
                "ERROR" => GetJobsCountStage.Error,
                "RUNNING" => GetJobsCountStage.Running,
                _ => null,
            };
        }
    }
}