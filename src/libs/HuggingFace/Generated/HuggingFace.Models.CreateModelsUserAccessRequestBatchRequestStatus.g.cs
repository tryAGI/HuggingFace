
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelsUserAccessRequestBatchRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Accepted,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelsUserAccessRequestBatchRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsUserAccessRequestBatchRequestStatus value)
        {
            return value switch
            {
                CreateModelsUserAccessRequestBatchRequestStatus.Accepted => "accepted",
                CreateModelsUserAccessRequestBatchRequestStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsUserAccessRequestBatchRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => CreateModelsUserAccessRequestBatchRequestStatus.Accepted,
                "rejected" => CreateModelsUserAccessRequestBatchRequestStatus.Rejected,
                _ => null,
            };
        }
    }
}