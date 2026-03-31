
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsCountStage2
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
    public static class GetJobsCountStage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsCountStage2 value)
        {
            return value switch
            {
                GetJobsCountStage2.Canceled => "CANCELED",
                GetJobsCountStage2.Completed => "COMPLETED",
                GetJobsCountStage2.Deleted => "DELETED",
                GetJobsCountStage2.Error => "ERROR",
                GetJobsCountStage2.Running => "RUNNING",
                GetJobsCountStage2.Scheduling => "SCHEDULING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsCountStage2? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => GetJobsCountStage2.Canceled,
                "COMPLETED" => GetJobsCountStage2.Completed,
                "DELETED" => GetJobsCountStage2.Deleted,
                "ERROR" => GetJobsCountStage2.Error,
                "RUNNING" => GetJobsCountStage2.Running,
                "SCHEDULING" => GetJobsCountStage2.Scheduling,
                _ => null,
            };
        }
    }
}