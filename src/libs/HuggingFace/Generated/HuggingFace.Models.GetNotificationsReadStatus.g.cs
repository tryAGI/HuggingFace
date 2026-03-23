
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum GetNotificationsReadStatus
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
    public static class GetNotificationsReadStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetNotificationsReadStatus value)
        {
            return value switch
            {
                GetNotificationsReadStatus.All => "all",
                GetNotificationsReadStatus.Unread => "unread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetNotificationsReadStatus? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetNotificationsReadStatus.All,
                "unread" => GetNotificationsReadStatus.Unread,
                _ => null,
            };
        }
    }
}