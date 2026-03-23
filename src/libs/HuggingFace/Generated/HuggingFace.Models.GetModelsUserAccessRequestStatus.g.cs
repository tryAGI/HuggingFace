
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelsUserAccessRequestStatus
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
    public static class GetModelsUserAccessRequestStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsUserAccessRequestStatus value)
        {
            return value switch
            {
                GetModelsUserAccessRequestStatus.Accepted => "accepted",
                GetModelsUserAccessRequestStatus.Pending => "pending",
                GetModelsUserAccessRequestStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsUserAccessRequestStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => GetModelsUserAccessRequestStatus.Accepted,
                "pending" => GetModelsUserAccessRequestStatus.Pending,
                "rejected" => GetModelsUserAccessRequestStatus.Rejected,
                _ => null,
            };
        }
    }
}