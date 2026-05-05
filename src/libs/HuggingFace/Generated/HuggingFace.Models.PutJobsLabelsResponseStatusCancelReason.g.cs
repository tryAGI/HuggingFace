
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum PutJobsLabelsResponseStatusCancelReason
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
    public static class PutJobsLabelsResponseStatusCancelReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutJobsLabelsResponseStatusCancelReason value)
        {
            return value switch
            {
                PutJobsLabelsResponseStatusCancelReason.NoCredits => "NO_CREDITS",
                PutJobsLabelsResponseStatusCancelReason.NoSubscription => "NO_SUBSCRIPTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutJobsLabelsResponseStatusCancelReason? ToEnum(string value)
        {
            return value switch
            {
                "NO_CREDITS" => PutJobsLabelsResponseStatusCancelReason.NoCredits,
                "NO_SUBSCRIPTION" => PutJobsLabelsResponseStatusCancelReason.NoSubscription,
                _ => null,
            };
        }
    }
}