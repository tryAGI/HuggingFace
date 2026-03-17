
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum Mention
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Participating,
        /// <summary>
        /// 
        /// </summary>
        Mentions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MentionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Mention value)
        {
            return value switch
            {
                Mention.All => "all",
                Mention.Participating => "participating",
                Mention.Mentions => "mentions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Mention? ToEnum(string value)
        {
            return value switch
            {
                "all" => Mention.All,
                "participating" => Mention.Participating,
                "mentions" => Mention.Mentions,
                _ => null,
            };
        }
    }
}