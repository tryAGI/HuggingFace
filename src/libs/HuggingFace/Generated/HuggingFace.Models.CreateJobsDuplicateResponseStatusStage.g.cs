
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsDuplicateResponseStatusStage
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
    public static class CreateJobsDuplicateResponseStatusStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsDuplicateResponseStatusStage value)
        {
            return value switch
            {
                CreateJobsDuplicateResponseStatusStage.Canceled => "CANCELED",
                CreateJobsDuplicateResponseStatusStage.Completed => "COMPLETED",
                CreateJobsDuplicateResponseStatusStage.Deleted => "DELETED",
                CreateJobsDuplicateResponseStatusStage.Error => "ERROR",
                CreateJobsDuplicateResponseStatusStage.Running => "RUNNING",
                CreateJobsDuplicateResponseStatusStage.Scheduling => "SCHEDULING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsDuplicateResponseStatusStage? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => CreateJobsDuplicateResponseStatusStage.Canceled,
                "COMPLETED" => CreateJobsDuplicateResponseStatusStage.Completed,
                "DELETED" => CreateJobsDuplicateResponseStatusStage.Deleted,
                "ERROR" => CreateJobsDuplicateResponseStatusStage.Error,
                "RUNNING" => CreateJobsDuplicateResponseStatusStage.Running,
                "SCHEDULING" => CreateJobsDuplicateResponseStatusStage.Scheduling,
                _ => null,
            };
        }
    }
}