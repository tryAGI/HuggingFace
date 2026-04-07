
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsResponseItemStatusCancelReason
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
    public static class GetJobsResponseItemStatusCancelReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsResponseItemStatusCancelReason value)
        {
            return value switch
            {
                GetJobsResponseItemStatusCancelReason.NoCredits => "NO_CREDITS",
                GetJobsResponseItemStatusCancelReason.NoSubscription => "NO_SUBSCRIPTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsResponseItemStatusCancelReason? ToEnum(string value)
        {
            return value switch
            {
                "NO_CREDITS" => GetJobsResponseItemStatusCancelReason.NoCredits,
                "NO_SUBSCRIPTION" => GetJobsResponseItemStatusCancelReason.NoSubscription,
                _ => null,
            };
        }
    }
}