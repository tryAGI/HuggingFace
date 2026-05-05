
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutScheduledJobsLabelsResponseOwnerType
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
    public static class PutScheduledJobsLabelsResponseOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutScheduledJobsLabelsResponseOwnerType value)
        {
            return value switch
            {
                PutScheduledJobsLabelsResponseOwnerType.Org => "org",
                PutScheduledJobsLabelsResponseOwnerType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutScheduledJobsLabelsResponseOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "org" => PutScheduledJobsLabelsResponseOwnerType.Org,
                "user" => PutScheduledJobsLabelsResponseOwnerType.User,
                _ => null,
            };
        }
    }
}