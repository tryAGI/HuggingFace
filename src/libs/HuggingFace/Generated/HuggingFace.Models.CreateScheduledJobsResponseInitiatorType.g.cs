
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateScheduledJobsResponseInitiatorType
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
    public static class CreateScheduledJobsResponseInitiatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsResponseInitiatorType value)
        {
            return value switch
            {
                CreateScheduledJobsResponseInitiatorType.Org => "org",
                CreateScheduledJobsResponseInitiatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsResponseInitiatorType? ToEnum(string value)
        {
            return value switch
            {
                "org" => CreateScheduledJobsResponseInitiatorType.Org,
                "user" => CreateScheduledJobsResponseInitiatorType.User,
                _ => null,
            };
        }
    }
}