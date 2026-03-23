
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetModelsUserAccessRequestResponseItemStatus
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
    public static class GetModelsUserAccessRequestResponseItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsUserAccessRequestResponseItemStatus value)
        {
            return value switch
            {
                GetModelsUserAccessRequestResponseItemStatus.Accepted => "accepted",
                GetModelsUserAccessRequestResponseItemStatus.Pending => "pending",
                GetModelsUserAccessRequestResponseItemStatus.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsUserAccessRequestResponseItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => GetModelsUserAccessRequestResponseItemStatus.Accepted,
                "pending" => GetModelsUserAccessRequestResponseItemStatus.Pending,
                "rejected" => GetModelsUserAccessRequestResponseItemStatus.Rejected,
                _ => null,
            };
        }
    }
}