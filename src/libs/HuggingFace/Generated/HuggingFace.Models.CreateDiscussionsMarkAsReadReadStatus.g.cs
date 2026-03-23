
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum CreateDiscussionsMarkAsReadReadStatus
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
    public static class CreateDiscussionsMarkAsReadReadStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsMarkAsReadReadStatus value)
        {
            return value switch
            {
                CreateDiscussionsMarkAsReadReadStatus.All => "all",
                CreateDiscussionsMarkAsReadReadStatus.Unread => "unread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsMarkAsReadReadStatus? ToEnum(string value)
        {
            return value switch
            {
                "all" => CreateDiscussionsMarkAsReadReadStatus.All,
                "unread" => CreateDiscussionsMarkAsReadReadStatus.Unread,
                _ => null,
            };
        }
    }
}