
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutJobsExposeResponseStatusCancelReason
    {
        /// <summary>
        /// 
        /// </summary>
        NoCredits,
        /// <summary>
        /// 
        /// </summary>
        NoSubscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PutJobsExposeResponseStatusCancelReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutJobsExposeResponseStatusCancelReason value)
        {
            return value switch
            {
                PutJobsExposeResponseStatusCancelReason.NoCredits => "NO_CREDITS",
                PutJobsExposeResponseStatusCancelReason.NoSubscription => "NO_SUBSCRIPTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutJobsExposeResponseStatusCancelReason? ToEnum(string value)
        {
            return value switch
            {
                "NO_CREDITS" => PutJobsExposeResponseStatusCancelReason.NoCredits,
                "NO_SUBSCRIPTION" => PutJobsExposeResponseStatusCancelReason.NoSubscription,
                _ => null,
            };
        }
    }
}