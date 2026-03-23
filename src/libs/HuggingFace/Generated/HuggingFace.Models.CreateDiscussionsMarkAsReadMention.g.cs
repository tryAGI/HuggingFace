
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum CreateDiscussionsMarkAsReadMention
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
    public static class CreateDiscussionsMarkAsReadMentionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsMarkAsReadMention value)
        {
            return value switch
            {
                CreateDiscussionsMarkAsReadMention.All => "all",
                CreateDiscussionsMarkAsReadMention.Mentions => "mentions",
                CreateDiscussionsMarkAsReadMention.Participating => "participating",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsMarkAsReadMention? ToEnum(string value)
        {
            return value switch
            {
                "all" => CreateDiscussionsMarkAsReadMention.All,
                "mentions" => CreateDiscussionsMarkAsReadMention.Mentions,
                "participating" => CreateDiscussionsMarkAsReadMention.Participating,
                _ => null,
            };
        }
    }
}