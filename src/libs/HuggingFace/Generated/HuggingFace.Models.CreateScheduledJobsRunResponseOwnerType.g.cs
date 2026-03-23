
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateScheduledJobsRunResponseOwnerType
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
    public static class CreateScheduledJobsRunResponseOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsRunResponseOwnerType value)
        {
            return value switch
            {
                CreateScheduledJobsRunResponseOwnerType.Org => "org",
                CreateScheduledJobsRunResponseOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsRunResponseOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "org" => CreateScheduledJobsRunResponseOwnerType.Org,
                "user" => CreateScheduledJobsRunResponseOwnerType.User,
                _ => null,
            };
        }
    }
}