
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDatasetsUserAccessRequestBatchRequestStatus
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
    public static class CreateDatasetsUserAccessRequestBatchRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsUserAccessRequestBatchRequestStatus value)
        {
            return value switch
            {
                CreateDatasetsUserAccessRequestBatchRequestStatus.Accepted => "accepted",
                CreateDatasetsUserAccessRequestBatchRequestStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsUserAccessRequestBatchRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => CreateDatasetsUserAccessRequestBatchRequestStatus.Accepted,
                "rejected" => CreateDatasetsUserAccessRequestBatchRequestStatus.Rejected,
                _ => null,
            };
        }
    }
}