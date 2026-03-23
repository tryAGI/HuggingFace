
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum DeleteNotificationsReadStatus
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
    public static class DeleteNotificationsReadStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteNotificationsReadStatus value)
        {
            return value switch
            {
                DeleteNotificationsReadStatus.All => "all",
                DeleteNotificationsReadStatus.Unread => "unread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteNotificationsReadStatus? ToEnum(string value)
        {
            return value switch
            {
                "all" => DeleteNotificationsReadStatus.All,
                "unread" => DeleteNotificationsReadStatus.Unread,
                _ => null,
            };
        }
    }
}