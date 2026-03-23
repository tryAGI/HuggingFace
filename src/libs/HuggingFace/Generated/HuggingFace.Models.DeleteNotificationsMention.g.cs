
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum DeleteNotificationsMention
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
    public static class DeleteNotificationsMentionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteNotificationsMention value)
        {
            return value switch
            {
                DeleteNotificationsMention.All => "all",
                DeleteNotificationsMention.Mentions => "mentions",
                DeleteNotificationsMention.Participating => "participating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteNotificationsMention? ToEnum(string value)
        {
            return value switch
            {
                "all" => DeleteNotificationsMention.All,
                "mentions" => DeleteNotificationsMention.Mentions,
                "participating" => DeleteNotificationsMention.Participating,
                _ => null,
            };
        }
    }
}