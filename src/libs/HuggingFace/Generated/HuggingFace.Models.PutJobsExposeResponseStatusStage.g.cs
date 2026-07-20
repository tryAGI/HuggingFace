
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutJobsExposeResponseStatusStage
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
    public static class PutJobsExposeResponseStatusStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutJobsExposeResponseStatusStage value)
        {
            return value switch
            {
                PutJobsExposeResponseStatusStage.Canceled => "CANCELED",
                PutJobsExposeResponseStatusStage.Completed => "COMPLETED",
                PutJobsExposeResponseStatusStage.Deleted => "DELETED",
                PutJobsExposeResponseStatusStage.Error => "ERROR",
                PutJobsExposeResponseStatusStage.Running => "RUNNING",
                PutJobsExposeResponseStatusStage.Scheduling => "SCHEDULING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutJobsExposeResponseStatusStage? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => PutJobsExposeResponseStatusStage.Canceled,
                "COMPLETED" => PutJobsExposeResponseStatusStage.Completed,
                "DELETED" => PutJobsExposeResponseStatusStage.Deleted,
                "ERROR" => PutJobsExposeResponseStatusStage.Error,
                "RUNNING" => PutJobsExposeResponseStatusStage.Running,
                "SCHEDULING" => PutJobsExposeResponseStatusStage.Scheduling,
                _ => null,
            };
        }
    }
}