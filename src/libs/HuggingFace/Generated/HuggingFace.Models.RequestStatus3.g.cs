
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestStatus3
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
    public static class RequestStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestStatus3 value)
        {
            return value switch
            {
                RequestStatus3.Accepted => "accepted",
                RequestStatus3.Rejected => "rejected",
                RequestStatus3.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestStatus3? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => RequestStatus3.Accepted,
                "rejected" => RequestStatus3.Rejected,
                "pending" => RequestStatus3.Pending,
                _ => null,
            };
        }
    }
}