
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateScheduledJobsScheduleResponseInitiatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Org,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateScheduledJobsScheduleResponseInitiatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsScheduleResponseInitiatorType value)
        {
            return value switch
            {
                CreateScheduledJobsScheduleResponseInitiatorType.Org => "org",
                CreateScheduledJobsScheduleResponseInitiatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsScheduleResponseInitiatorType? ToEnum(string value)
        {
            return value switch
            {
                "org" => CreateScheduledJobsScheduleResponseInitiatorType.Org,
                "user" => CreateScheduledJobsScheduleResponseInitiatorType.User,
                _ => null,
            };
        }
    }
}