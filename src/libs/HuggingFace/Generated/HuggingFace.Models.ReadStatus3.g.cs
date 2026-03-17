
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum ReadStatus3
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
    public static class ReadStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadStatus3 value)
        {
            return value switch
            {
                ReadStatus3.All => "all",
                ReadStatus3.Unread => "unread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadStatus3? ToEnum(string value)
        {
            return value switch
            {
                "all" => ReadStatus3.All,
                "unread" => ReadStatus3.Unread,
                _ => null,
            };
        }
    }
}