
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateScheduledJobsResponseOwnerType
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
    public static class CreateScheduledJobsResponseOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsResponseOwnerType value)
        {
            return value switch
            {
                CreateScheduledJobsResponseOwnerType.Org => "org",
                CreateScheduledJobsResponseOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsResponseOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "org" => CreateScheduledJobsResponseOwnerType.Org,
                "user" => CreateScheduledJobsResponseOwnerType.User,
                _ => null,
            };
        }
    }
}