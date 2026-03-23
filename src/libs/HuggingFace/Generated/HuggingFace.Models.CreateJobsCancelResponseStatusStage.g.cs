
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsCancelResponseStatusStage
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
    public static class CreateJobsCancelResponseStatusStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsCancelResponseStatusStage value)
        {
            return value switch
            {
                CreateJobsCancelResponseStatusStage.Canceled => "CANCELED",
                CreateJobsCancelResponseStatusStage.Completed => "COMPLETED",
                CreateJobsCancelResponseStatusStage.Deleted => "DELETED",
                CreateJobsCancelResponseStatusStage.Error => "ERROR",
                CreateJobsCancelResponseStatusStage.Running => "RUNNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsCancelResponseStatusStage? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => CreateJobsCancelResponseStatusStage.Canceled,
                "COMPLETED" => CreateJobsCancelResponseStatusStage.Completed,
                "DELETED" => CreateJobsCancelResponseStatusStage.Deleted,
                "ERROR" => CreateJobsCancelResponseStatusStage.Error,
                "RUNNING" => CreateJobsCancelResponseStatusStage.Running,
                _ => null,
            };
        }
    }
}