
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateModelsUserAccessRequestHandleRequestStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Accepted,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateModelsUserAccessRequestHandleRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsUserAccessRequestHandleRequestStatus value)
        {
            return value switch
            {
                CreateModelsUserAccessRequestHandleRequestStatus.Accepted => "accepted",
                CreateModelsUserAccessRequestHandleRequestStatus.Pending => "pending",
                CreateModelsUserAccessRequestHandleRequestStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsUserAccessRequestHandleRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => CreateModelsUserAccessRequestHandleRequestStatus.Accepted,
                "pending" => CreateModelsUserAccessRequestHandleRequestStatus.Pending,
                "rejected" => CreateModelsUserAccessRequestHandleRequestStatus.Rejected,
                _ => null,
            };
        }
    }
}