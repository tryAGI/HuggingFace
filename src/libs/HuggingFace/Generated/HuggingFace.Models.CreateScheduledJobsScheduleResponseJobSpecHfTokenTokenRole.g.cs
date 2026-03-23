
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateScheduledJobsScheduleResponseJobSpecHfTokenTokenRole
    {
        /// <summary>
        /// 
        /// </summary>
        FineGrained,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateScheduledJobsScheduleResponseJobSpecHfTokenTokenRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsScheduleResponseJobSpecHfTokenTokenRole value)
        {
            return value switch
            {
                CreateScheduledJobsScheduleResponseJobSpecHfTokenTokenRole.FineGrained => "fineGrained",
                CreateScheduledJobsScheduleResponseJobSpecHfTokenTokenRole.Read => "read",
                CreateScheduledJobsScheduleResponseJobSpecHfTokenTokenRole.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsScheduleResponseJobSpecHfTokenTokenRole? ToEnum(string value)
        {
            return value switch
            {
                "fineGrained" => CreateScheduledJobsScheduleResponseJobSpecHfTokenTokenRole.FineGrained,
                "read" => CreateScheduledJobsScheduleResponseJobSpecHfTokenTokenRole.Read,
                "write" => CreateScheduledJobsScheduleResponseJobSpecHfTokenTokenRole.Write,
                _ => null,
            };
        }
    }
}