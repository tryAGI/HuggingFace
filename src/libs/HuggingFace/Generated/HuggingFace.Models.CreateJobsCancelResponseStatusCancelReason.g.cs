
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsCancelResponseStatusCancelReason
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
    public static class CreateJobsCancelResponseStatusCancelReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsCancelResponseStatusCancelReason value)
        {
            return value switch
            {
                CreateJobsCancelResponseStatusCancelReason.NoCredits => "NO_CREDITS",
                CreateJobsCancelResponseStatusCancelReason.NoSubscription => "NO_SUBSCRIPTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsCancelResponseStatusCancelReason? ToEnum(string value)
        {
            return value switch
            {
                "NO_CREDITS" => CreateJobsCancelResponseStatusCancelReason.NoCredits,
                "NO_SUBSCRIPTION" => CreateJobsCancelResponseStatusCancelReason.NoSubscription,
                _ => null,
            };
        }
    }
}