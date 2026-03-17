
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Accepted,
        /// <summary>
        /// 
        /// </summary>
        Rejected,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemStatus value)
        {
            return value switch
            {
                ResponseItemStatus.Accepted => "accepted",
                ResponseItemStatus.Rejected => "rejected",
                ResponseItemStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => ResponseItemStatus.Accepted,
                "rejected" => ResponseItemStatus.Rejected,
                "pending" => ResponseItemStatus.Pending,
                _ => null,
            };
        }
    }
}