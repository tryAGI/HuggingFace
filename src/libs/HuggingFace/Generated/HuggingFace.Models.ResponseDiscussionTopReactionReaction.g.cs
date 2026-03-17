
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDiscussionTopReactionReaction
    {
        /// <summary>
        /// 
        /// </summary>
        x__,
        /// <summary>
        /// 
        /// </summary>
        x__,
        /// <summary>
        /// 
        /// </summary>
        x__,
        /// <summary>
        /// 
        /// </summary>
        x__,
        /// <summary>
        /// 
        /// </summary>
        x__,
        /// <summary>
        /// 
        /// </summary>
        x__,
        /// <summary>
        /// 
        /// </summary>
        x_,
        /// <summary>
        /// 
        /// </summary>
        x__,
        /// <summary>
        /// 
        /// </summary>
        x__,
        /// <summary>
        /// 
        /// </summary>
        x__,
        /// <summary>
        /// 
        /// </summary>
        x__,
        /// <summary>
        /// 
        /// </summary>
        x__,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseDiscussionTopReactionReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDiscussionTopReactionReaction value)
        {
            return value switch
            {
                ResponseDiscussionTopReactionReaction.x__ => "🔥",
                ResponseDiscussionTopReactionReaction.x__ => "🚀",
                ResponseDiscussionTopReactionReaction.x__ => "👀",
                ResponseDiscussionTopReactionReaction.x__ => "❤️",
                ResponseDiscussionTopReactionReaction.x__ => "🤗",
                ResponseDiscussionTopReactionReaction.x__ => "😎",
                ResponseDiscussionTopReactionReaction.x_ => "➕",
                ResponseDiscussionTopReactionReaction.x__ => "🧠",
                ResponseDiscussionTopReactionReaction.x__ => "👍",
                ResponseDiscussionTopReactionReaction.x__ => "🤝",
                ResponseDiscussionTopReactionReaction.x__ => "😔",
                ResponseDiscussionTopReactionReaction.x__ => "🤯",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDiscussionTopReactionReaction? ToEnum(string value)
        {
            return value switch
            {
                "🔥" => ResponseDiscussionTopReactionReaction.x__,
                "🚀" => ResponseDiscussionTopReactionReaction.x__,
                "👀" => ResponseDiscussionTopReactionReaction.x__,
                "❤️" => ResponseDiscussionTopReactionReaction.x__,
                "🤗" => ResponseDiscussionTopReactionReaction.x__,
                "😎" => ResponseDiscussionTopReactionReaction.x__,
                "➕" => ResponseDiscussionTopReactionReaction.x_,
                "🧠" => ResponseDiscussionTopReactionReaction.x__,
                "👍" => ResponseDiscussionTopReactionReaction.x__,
                "🤝" => ResponseDiscussionTopReactionReaction.x__,
                "😔" => ResponseDiscussionTopReactionReaction.x__,
                "🤯" => ResponseDiscussionTopReactionReaction.x__,
                _ => null,
            };
        }
    }
}