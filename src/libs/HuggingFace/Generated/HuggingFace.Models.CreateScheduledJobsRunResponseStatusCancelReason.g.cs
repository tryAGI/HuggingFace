
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateScheduledJobsRunResponseStatusCancelReason
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
    public static class CreateScheduledJobsRunResponseStatusCancelReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateScheduledJobsRunResponseStatusCancelReason value)
        {
            return value switch
            {
                CreateScheduledJobsRunResponseStatusCancelReason.NoCredits => "NO_CREDITS",
                CreateScheduledJobsRunResponseStatusCancelReason.NoSubscription => "NO_SUBSCRIPTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateScheduledJobsRunResponseStatusCancelReason? ToEnum(string value)
        {
            return value switch
            {
                "NO_CREDITS" => CreateScheduledJobsRunResponseStatusCancelReason.NoCredits,
                "NO_SUBSCRIPTION" => CreateScheduledJobsRunResponseStatusCancelReason.NoSubscription,
                _ => null,
            };
        }
    }
}