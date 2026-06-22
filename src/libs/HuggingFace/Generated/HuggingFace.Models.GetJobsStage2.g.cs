
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsStage2
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
    public static class GetJobsStage2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsStage2 value)
        {
            return value switch
            {
                GetJobsStage2.Canceled => "CANCELED",
                GetJobsStage2.Completed => "COMPLETED",
                GetJobsStage2.Deleted => "DELETED",
                GetJobsStage2.Error => "ERROR",
                GetJobsStage2.Running => "RUNNING",
                GetJobsStage2.Scheduling => "SCHEDULING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsStage2? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => GetJobsStage2.Canceled,
                "COMPLETED" => GetJobsStage2.Completed,
                "DELETED" => GetJobsStage2.Deleted,
                "ERROR" => GetJobsStage2.Error,
                "RUNNING" => GetJobsStage2.Running,
                "SCHEDULING" => GetJobsStage2.Scheduling,
                _ => null,
            };
        }
    }
}