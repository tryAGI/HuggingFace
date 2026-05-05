
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutJobsLabelsResponseStatusStage
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
    public static class PutJobsLabelsResponseStatusStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutJobsLabelsResponseStatusStage value)
        {
            return value switch
            {
                PutJobsLabelsResponseStatusStage.Canceled => "CANCELED",
                PutJobsLabelsResponseStatusStage.Completed => "COMPLETED",
                PutJobsLabelsResponseStatusStage.Deleted => "DELETED",
                PutJobsLabelsResponseStatusStage.Error => "ERROR",
                PutJobsLabelsResponseStatusStage.Running => "RUNNING",
                PutJobsLabelsResponseStatusStage.Scheduling => "SCHEDULING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutJobsLabelsResponseStatusStage? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => PutJobsLabelsResponseStatusStage.Canceled,
                "COMPLETED" => PutJobsLabelsResponseStatusStage.Completed,
                "DELETED" => PutJobsLabelsResponseStatusStage.Deleted,
                "ERROR" => PutJobsLabelsResponseStatusStage.Error,
                "RUNNING" => PutJobsLabelsResponseStatusStage.Running,
                "SCHEDULING" => PutJobsLabelsResponseStatusStage.Scheduling,
                _ => null,
            };
        }
    }
}