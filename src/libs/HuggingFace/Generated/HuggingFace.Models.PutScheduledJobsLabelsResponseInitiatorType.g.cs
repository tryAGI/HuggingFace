
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutScheduledJobsLabelsResponseInitiatorType
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
    public static class PutScheduledJobsLabelsResponseInitiatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutScheduledJobsLabelsResponseInitiatorType value)
        {
            return value switch
            {
                PutScheduledJobsLabelsResponseInitiatorType.Org => "org",
                PutScheduledJobsLabelsResponseInitiatorType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutScheduledJobsLabelsResponseInitiatorType? ToEnum(string value)
        {
            return value switch
            {
                "org" => PutScheduledJobsLabelsResponseInitiatorType.Org,
                "user" => PutScheduledJobsLabelsResponseInitiatorType.User,
                _ => null,
            };
        }
    }
}