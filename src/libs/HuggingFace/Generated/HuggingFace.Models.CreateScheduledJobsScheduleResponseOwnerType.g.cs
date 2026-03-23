
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateScheduledJobsScheduleResponseOwnerType
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
    public static class CreateScheduledJobsScheduleResponseOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsScheduleResponseOwnerType value)
        {
            return value switch
            {
                CreateScheduledJobsScheduleResponseOwnerType.Org => "org",
                CreateScheduledJobsScheduleResponseOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsScheduleResponseOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "org" => CreateScheduledJobsScheduleResponseOwnerType.Org,
                "user" => CreateScheduledJobsScheduleResponseOwnerType.User,
                _ => null,
            };
        }
    }
}