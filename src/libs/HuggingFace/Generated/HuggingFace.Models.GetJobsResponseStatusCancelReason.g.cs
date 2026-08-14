
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetJobsResponseStatusCancelReason
    {
        /// <summary>
        /// 
        /// </summary>
        NoCredits,
        /// <summary>
        /// 
        /// </summary>
        NoSubscription,
        /// <summary>
        /// 
        /// </summary>
        ResourceGroupLimit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetJobsResponseStatusCancelReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetJobsResponseStatusCancelReason value)
        {
            return value switch
            {
                GetJobsResponseStatusCancelReason.NoCredits => "NO_CREDITS",
                GetJobsResponseStatusCancelReason.NoSubscription => "NO_SUBSCRIPTION",
                GetJobsResponseStatusCancelReason.ResourceGroupLimit => "RESOURCE_GROUP_LIMIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetJobsResponseStatusCancelReason? ToEnum(string value)
        {
            return value switch
            {
                "NO_CREDITS" => GetJobsResponseStatusCancelReason.NoCredits,
                "NO_SUBSCRIPTION" => GetJobsResponseStatusCancelReason.NoSubscription,
                "RESOURCE_GROUP_LIMIT" => GetJobsResponseStatusCancelReason.ResourceGroupLimit,
                _ => null,
            };
        }
    }
}