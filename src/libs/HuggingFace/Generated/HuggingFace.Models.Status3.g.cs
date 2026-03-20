
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum Status3
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
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
    public static class Status3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Status3 value)
        {
            return value switch
            {
                Status3.Pending => "pending",
                Status3.Accepted => "accepted",
                Status3.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Status3? ToEnum(string value)
        {
            return value switch
            {
                "pending" => Status3.Pending,
                "accepted" => Status3.Accepted,
                "rejected" => Status3.Rejected,
                _ => null,
            };
        }
    }
}