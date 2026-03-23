
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum GetNotificationsMention
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
    public static class GetNotificationsMentionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetNotificationsMention value)
        {
            return value switch
            {
                GetNotificationsMention.All => "all",
                GetNotificationsMention.Mentions => "mentions",
                GetNotificationsMention.Participating => "participating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetNotificationsMention? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetNotificationsMention.All,
                "mentions" => GetNotificationsMention.Mentions,
                "participating" => GetNotificationsMention.Participating,
                _ => null,
            };
        }
    }
}