
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetScheduledJobsResponseInitiatorType
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
    public static class GetScheduledJobsResponseInitiatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScheduledJobsResponseInitiatorType value)
        {
            return value switch
            {
                GetScheduledJobsResponseInitiatorType.Org => "org",
                GetScheduledJobsResponseInitiatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScheduledJobsResponseInitiatorType? ToEnum(string value)
        {
            return value switch
            {
                "org" => GetScheduledJobsResponseInitiatorType.Org,
                "user" => GetScheduledJobsResponseInitiatorType.User,
                _ => null,
            };
        }
    }
}