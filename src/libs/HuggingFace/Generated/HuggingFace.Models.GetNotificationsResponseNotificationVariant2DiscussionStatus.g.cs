
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetNotificationsResponseNotificationVariant2DiscussionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Merged,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetNotificationsResponseNotificationVariant2DiscussionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetNotificationsResponseNotificationVariant2DiscussionStatus value)
        {
            return value switch
            {
                GetNotificationsResponseNotificationVariant2DiscussionStatus.Closed => "closed",
                GetNotificationsResponseNotificationVariant2DiscussionStatus.Draft => "draft",
                GetNotificationsResponseNotificationVariant2DiscussionStatus.Merged => "merged",
                GetNotificationsResponseNotificationVariant2DiscussionStatus.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetNotificationsResponseNotificationVariant2DiscussionStatus? ToEnum(string value)
        {
            return value switch
            {
                "closed" => GetNotificationsResponseNotificationVariant2DiscussionStatus.Closed,
                "draft" => GetNotificationsResponseNotificationVariant2DiscussionStatus.Draft,
                "merged" => GetNotificationsResponseNotificationVariant2DiscussionStatus.Merged,
                "open" => GetNotificationsResponseNotificationVariant2DiscussionStatus.Open,
                _ => null,
            };
        }
    }
}