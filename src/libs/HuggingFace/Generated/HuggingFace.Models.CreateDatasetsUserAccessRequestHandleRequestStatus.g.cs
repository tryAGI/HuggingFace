
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDatasetsUserAccessRequestHandleRequestStatus
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
    public static class CreateDatasetsUserAccessRequestHandleRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDatasetsUserAccessRequestHandleRequestStatus value)
        {
            return value switch
            {
                CreateDatasetsUserAccessRequestHandleRequestStatus.Accepted => "accepted",
                CreateDatasetsUserAccessRequestHandleRequestStatus.Pending => "pending",
                CreateDatasetsUserAccessRequestHandleRequestStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDatasetsUserAccessRequestHandleRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => CreateDatasetsUserAccessRequestHandleRequestStatus.Accepted,
                "pending" => CreateDatasetsUserAccessRequestHandleRequestStatus.Pending,
                "rejected" => CreateDatasetsUserAccessRequestHandleRequestStatus.Rejected,
                _ => null,
            };
        }
    }
}