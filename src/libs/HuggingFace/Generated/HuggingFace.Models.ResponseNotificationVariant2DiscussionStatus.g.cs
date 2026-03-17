
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNotificationVariant2DiscussionStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Draft,
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Merged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseNotificationVariant2DiscussionStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNotificationVariant2DiscussionStatus value)
        {
            return value switch
            {
                ResponseNotificationVariant2DiscussionStatus.Draft => "draft",
                ResponseNotificationVariant2DiscussionStatus.Open => "open",
                ResponseNotificationVariant2DiscussionStatus.Closed => "closed",
                ResponseNotificationVariant2DiscussionStatus.Merged => "merged",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNotificationVariant2DiscussionStatus? ToEnum(string value)
        {
            return value switch
            {
                "draft" => ResponseNotificationVariant2DiscussionStatus.Draft,
                "open" => ResponseNotificationVariant2DiscussionStatus.Open,
                "closed" => ResponseNotificationVariant2DiscussionStatus.Closed,
                "merged" => ResponseNotificationVariant2DiscussionStatus.Merged,
                _ => null,
            };
        }
    }
}