
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsStageItem
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
    public static class GetJobsStageItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsStageItem value)
        {
            return value switch
            {
                GetJobsStageItem.Canceled => "CANCELED",
                GetJobsStageItem.Completed => "COMPLETED",
                GetJobsStageItem.Deleted => "DELETED",
                GetJobsStageItem.Error => "ERROR",
                GetJobsStageItem.Running => "RUNNING",
                GetJobsStageItem.Scheduling => "SCHEDULING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsStageItem? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => GetJobsStageItem.Canceled,
                "COMPLETED" => GetJobsStageItem.Completed,
                "DELETED" => GetJobsStageItem.Deleted,
                "ERROR" => GetJobsStageItem.Error,
                "RUNNING" => GetJobsStageItem.Running,
                "SCHEDULING" => GetJobsStageItem.Scheduling,
                _ => null,
            };
        }
    }
}