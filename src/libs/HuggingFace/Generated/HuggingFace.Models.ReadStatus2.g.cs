
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum ReadStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Unread,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReadStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadStatus2 value)
        {
            return value switch
            {
                ReadStatus2.All => "all",
                ReadStatus2.Unread => "unread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadStatus2? ToEnum(string value)
        {
            return value switch
            {
                "all" => ReadStatus2.All,
                "unread" => ReadStatus2.Unread,
                _ => null,
            };
        }
    }
}