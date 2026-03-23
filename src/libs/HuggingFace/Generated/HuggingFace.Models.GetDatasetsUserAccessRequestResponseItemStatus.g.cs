
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDatasetsUserAccessRequestResponseItemStatus
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
    public static class GetDatasetsUserAccessRequestResponseItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDatasetsUserAccessRequestResponseItemStatus value)
        {
            return value switch
            {
                GetDatasetsUserAccessRequestResponseItemStatus.Accepted => "accepted",
                GetDatasetsUserAccessRequestResponseItemStatus.Pending => "pending",
                GetDatasetsUserAccessRequestResponseItemStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDatasetsUserAccessRequestResponseItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => GetDatasetsUserAccessRequestResponseItemStatus.Accepted,
                "pending" => GetDatasetsUserAccessRequestResponseItemStatus.Pending,
                "rejected" => GetDatasetsUserAccessRequestResponseItemStatus.Rejected,
                _ => null,
            };
        }
    }
}