
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum CreateNotificationsMarkAsReadReadStatus
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
    public static class CreateNotificationsMarkAsReadReadStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateNotificationsMarkAsReadReadStatus value)
        {
            return value switch
            {
                CreateNotificationsMarkAsReadReadStatus.All => "all",
                CreateNotificationsMarkAsReadReadStatus.Unread => "unread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateNotificationsMarkAsReadReadStatus? ToEnum(string value)
        {
            return value switch
            {
                "all" => CreateNotificationsMarkAsReadReadStatus.All,
                "unread" => CreateNotificationsMarkAsReadReadStatus.Unread,
                _ => null,
            };
        }
    }
}