
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsResponseStatusCancelReason
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
    public static class CreateJobsResponseStatusCancelReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsResponseStatusCancelReason value)
        {
            return value switch
            {
                CreateJobsResponseStatusCancelReason.NoCredits => "NO_CREDITS",
                CreateJobsResponseStatusCancelReason.NoSubscription => "NO_SUBSCRIPTION",
                CreateJobsResponseStatusCancelReason.ResourceGroupLimit => "RESOURCE_GROUP_LIMIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsResponseStatusCancelReason? ToEnum(string value)
        {
            return value switch
            {
                "NO_CREDITS" => CreateJobsResponseStatusCancelReason.NoCredits,
                "NO_SUBSCRIPTION" => CreateJobsResponseStatusCancelReason.NoSubscription,
                "RESOURCE_GROUP_LIMIT" => CreateJobsResponseStatusCancelReason.ResourceGroupLimit,
                _ => null,
            };
        }
    }
}