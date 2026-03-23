
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateScheduledJobsScheduleResponseJobSpecArch
    {
        /// <summary>
        /// 
        /// </summary>
        Amd64,
        /// <summary>
        /// 
        /// </summary>
        Arm64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateScheduledJobsScheduleResponseJobSpecArchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsScheduleResponseJobSpecArch value)
        {
            return value switch
            {
                CreateScheduledJobsScheduleResponseJobSpecArch.Amd64 => "amd64",
                CreateScheduledJobsScheduleResponseJobSpecArch.Arm64 => "arm64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsScheduleResponseJobSpecArch? ToEnum(string value)
        {
            return value switch
            {
                "amd64" => CreateScheduledJobsScheduleResponseJobSpecArch.Amd64,
                "arm64" => CreateScheduledJobsScheduleResponseJobSpecArch.Arm64,
                _ => null,
            };
        }
    }
}