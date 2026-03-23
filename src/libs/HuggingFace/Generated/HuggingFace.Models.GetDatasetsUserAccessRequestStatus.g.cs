
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsUserAccessRequestStatus
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
    public static class GetDatasetsUserAccessRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsUserAccessRequestStatus value)
        {
            return value switch
            {
                GetDatasetsUserAccessRequestStatus.Accepted => "accepted",
                GetDatasetsUserAccessRequestStatus.Pending => "pending",
                GetDatasetsUserAccessRequestStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsUserAccessRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => GetDatasetsUserAccessRequestStatus.Accepted,
                "pending" => GetDatasetsUserAccessRequestStatus.Pending,
                "rejected" => GetDatasetsUserAccessRequestStatus.Rejected,
                _ => null,
            };
        }
    }
}