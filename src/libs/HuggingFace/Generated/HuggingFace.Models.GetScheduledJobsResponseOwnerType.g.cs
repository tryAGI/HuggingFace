
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetScheduledJobsResponseOwnerType
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
    public static class GetScheduledJobsResponseOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScheduledJobsResponseOwnerType value)
        {
            return value switch
            {
                GetScheduledJobsResponseOwnerType.Org => "org",
                GetScheduledJobsResponseOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScheduledJobsResponseOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "org" => GetScheduledJobsResponseOwnerType.Org,
                "user" => GetScheduledJobsResponseOwnerType.User,
                _ => null,
            };
        }
    }
}