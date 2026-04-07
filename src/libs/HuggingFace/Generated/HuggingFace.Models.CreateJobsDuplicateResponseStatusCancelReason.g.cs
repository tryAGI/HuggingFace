
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateJobsDuplicateResponseStatusCancelReason
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
    public static class CreateJobsDuplicateResponseStatusCancelReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateJobsDuplicateResponseStatusCancelReason value)
        {
            return value switch
            {
                CreateJobsDuplicateResponseStatusCancelReason.NoCredits => "NO_CREDITS",
                CreateJobsDuplicateResponseStatusCancelReason.NoSubscription => "NO_SUBSCRIPTION",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateJobsDuplicateResponseStatusCancelReason? ToEnum(string value)
        {
            return value switch
            {
                "NO_CREDITS" => CreateJobsDuplicateResponseStatusCancelReason.NoCredits,
                "NO_SUBSCRIPTION" => CreateJobsDuplicateResponseStatusCancelReason.NoSubscription,
                _ => null,
            };
        }
    }
}