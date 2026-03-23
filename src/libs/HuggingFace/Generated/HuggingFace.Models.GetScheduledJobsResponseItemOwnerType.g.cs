
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetScheduledJobsResponseItemOwnerType
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
    public static class GetScheduledJobsResponseItemOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScheduledJobsResponseItemOwnerType value)
        {
            return value switch
            {
                GetScheduledJobsResponseItemOwnerType.Org => "org",
                GetScheduledJobsResponseItemOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScheduledJobsResponseItemOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "org" => GetScheduledJobsResponseItemOwnerType.Org,
                "user" => GetScheduledJobsResponseItemOwnerType.User,
                _ => null,
            };
        }
    }
}