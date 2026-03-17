
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestStatus2
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
    public static class RequestStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestStatus2 value)
        {
            return value switch
            {
                RequestStatus2.Accepted => "accepted",
                RequestStatus2.Rejected => "rejected",
                RequestStatus2.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestStatus2? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => RequestStatus2.Accepted,
                "rejected" => RequestStatus2.Rejected,
                "pending" => RequestStatus2.Pending,
                _ => null,
            };
        }
    }
}