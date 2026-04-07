
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobStatusCancelReason
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
    public static class JobStatusCancelReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobStatusCancelReason value)
        {
            return value switch
            {
                JobStatusCancelReason.NoCredits => "NO_CREDITS",
                JobStatusCancelReason.NoSubscription => "NO_SUBSCRIPTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobStatusCancelReason? ToEnum(string value)
        {
            return value switch
            {
                "NO_CREDITS" => JobStatusCancelReason.NoCredits,
                "NO_SUBSCRIPTION" => JobStatusCancelReason.NoSubscription,
                _ => null,
            };
        }
    }
}