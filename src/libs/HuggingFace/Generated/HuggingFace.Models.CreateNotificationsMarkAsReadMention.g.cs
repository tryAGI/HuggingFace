
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum CreateNotificationsMarkAsReadMention
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Mentions,
        /// <summary>
        /// 
        /// </summary>
        Participating,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateNotificationsMarkAsReadMentionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateNotificationsMarkAsReadMention value)
        {
            return value switch
            {
                CreateNotificationsMarkAsReadMention.All => "all",
                CreateNotificationsMarkAsReadMention.Mentions => "mentions",
                CreateNotificationsMarkAsReadMention.Participating => "participating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateNotificationsMarkAsReadMention? ToEnum(string value)
        {
            return value switch
            {
                "all" => CreateNotificationsMarkAsReadMention.All,
                "mentions" => CreateNotificationsMarkAsReadMention.Mentions,
                "participating" => CreateNotificationsMarkAsReadMention.Participating,
                _ => null,
            };
        }
    }
}