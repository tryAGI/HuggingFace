
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum ReadStatus
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
    public static class ReadStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadStatus value)
        {
            return value switch
            {
                ReadStatus.All => "all",
                ReadStatus.Unread => "unread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadStatus? ToEnum(string value)
        {
            return value switch
            {
                "all" => ReadStatus.All,
                "unread" => ReadStatus.Unread,
                _ => null,
            };
        }
    }
}