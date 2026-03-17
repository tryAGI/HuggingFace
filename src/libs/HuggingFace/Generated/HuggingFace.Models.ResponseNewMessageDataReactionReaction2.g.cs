
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataReactionReaction2
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
    public static class ResponseNewMessageDataReactionReaction2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataReactionReaction2 value)
        {
            return value switch
            {
                ResponseNewMessageDataReactionReaction2.x__ => "🔥",
                ResponseNewMessageDataReactionReaction2.x__ => "🚀",
                ResponseNewMessageDataReactionReaction2.x__ => "👀",
                ResponseNewMessageDataReactionReaction2.x__ => "❤️",
                ResponseNewMessageDataReactionReaction2.x__ => "🤗",
                ResponseNewMessageDataReactionReaction2.x__ => "😎",
                ResponseNewMessageDataReactionReaction2.x_ => "➕",
                ResponseNewMessageDataReactionReaction2.x__ => "🧠",
                ResponseNewMessageDataReactionReaction2.x__ => "👍",
                ResponseNewMessageDataReactionReaction2.x__ => "🤝",
                ResponseNewMessageDataReactionReaction2.x__ => "😔",
                ResponseNewMessageDataReactionReaction2.x__ => "🤯",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataReactionReaction2? ToEnum(string value)
        {
            return value switch
            {
                "🔥" => ResponseNewMessageDataReactionReaction2.x__,
                "🚀" => ResponseNewMessageDataReactionReaction2.x__,
                "👀" => ResponseNewMessageDataReactionReaction2.x__,
                "❤️" => ResponseNewMessageDataReactionReaction2.x__,
                "🤗" => ResponseNewMessageDataReactionReaction2.x__,
                "😎" => ResponseNewMessageDataReactionReaction2.x__,
                "➕" => ResponseNewMessageDataReactionReaction2.x_,
                "🧠" => ResponseNewMessageDataReactionReaction2.x__,
                "👍" => ResponseNewMessageDataReactionReaction2.x__,
                "🤝" => ResponseNewMessageDataReactionReaction2.x__,
                "😔" => ResponseNewMessageDataReactionReaction2.x__,
                "🤯" => ResponseNewMessageDataReactionReaction2.x__,
                _ => null,
            };
        }
    }
}