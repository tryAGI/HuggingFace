
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseItemStatus2
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
    public static class ResponseItemStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseItemStatus2 value)
        {
            return value switch
            {
                ResponseItemStatus2.Accepted => "accepted",
                ResponseItemStatus2.Rejected => "rejected",
                ResponseItemStatus2.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseItemStatus2? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => ResponseItemStatus2.Accepted,
                "rejected" => ResponseItemStatus2.Rejected,
                "pending" => ResponseItemStatus2.Pending,
                _ => null,
            };
        }
    }
}