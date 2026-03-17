
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum Status2
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
    public static class Status2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Status2 value)
        {
            return value switch
            {
                Status2.Pending => "pending",
                Status2.Accepted => "accepted",
                Status2.Rejected => "rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Status2? ToEnum(string value)
        {
            return value switch
            {
                "pending" => Status2.Pending,
                "accepted" => Status2.Accepted,
                "rejected" => Status2.Rejected,
                _ => null,
            };
        }
    }
}