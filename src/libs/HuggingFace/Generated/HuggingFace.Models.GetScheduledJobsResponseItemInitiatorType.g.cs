
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetScheduledJobsResponseItemInitiatorType
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
    public static class GetScheduledJobsResponseItemInitiatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetScheduledJobsResponseItemInitiatorType value)
        {
            return value switch
            {
                GetScheduledJobsResponseItemInitiatorType.Org => "org",
                GetScheduledJobsResponseItemInitiatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetScheduledJobsResponseItemInitiatorType? ToEnum(string value)
        {
            return value switch
            {
                "org" => GetScheduledJobsResponseItemInitiatorType.Org,
                "user" => GetScheduledJobsResponseItemInitiatorType.User,
                _ => null,
            };
        }
    }
}