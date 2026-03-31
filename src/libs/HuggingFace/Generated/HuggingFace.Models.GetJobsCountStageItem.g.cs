
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsCountStageItem
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
    public static class GetJobsCountStageItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsCountStageItem value)
        {
            return value switch
            {
                GetJobsCountStageItem.Canceled => "CANCELED",
                GetJobsCountStageItem.Completed => "COMPLETED",
                GetJobsCountStageItem.Deleted => "DELETED",
                GetJobsCountStageItem.Error => "ERROR",
                GetJobsCountStageItem.Running => "RUNNING",
                GetJobsCountStageItem.Scheduling => "SCHEDULING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsCountStageItem? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => GetJobsCountStageItem.Canceled,
                "COMPLETED" => GetJobsCountStageItem.Completed,
                "DELETED" => GetJobsCountStageItem.Deleted,
                "ERROR" => GetJobsCountStageItem.Error,
                "RUNNING" => GetJobsCountStageItem.Running,
                "SCHEDULING" => GetJobsCountStageItem.Scheduling,
                _ => null,
            };
        }
    }
}