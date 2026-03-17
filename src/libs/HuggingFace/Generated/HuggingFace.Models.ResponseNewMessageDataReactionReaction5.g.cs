
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataReactionReaction5
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
    public static class ResponseNewMessageDataReactionReaction5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataReactionReaction5 value)
        {
            return value switch
            {
                ResponseNewMessageDataReactionReaction5.x__ => "🔥",
                ResponseNewMessageDataReactionReaction5.x__ => "🚀",
                ResponseNewMessageDataReactionReaction5.x__ => "👀",
                ResponseNewMessageDataReactionReaction5.x__ => "❤️",
                ResponseNewMessageDataReactionReaction5.x__ => "🤗",
                ResponseNewMessageDataReactionReaction5.x__ => "😎",
                ResponseNewMessageDataReactionReaction5.x_ => "➕",
                ResponseNewMessageDataReactionReaction5.x__ => "🧠",
                ResponseNewMessageDataReactionReaction5.x__ => "👍",
                ResponseNewMessageDataReactionReaction5.x__ => "🤝",
                ResponseNewMessageDataReactionReaction5.x__ => "😔",
                ResponseNewMessageDataReactionReaction5.x__ => "🤯",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataReactionReaction5? ToEnum(string value)
        {
            return value switch
            {
                "🔥" => ResponseNewMessageDataReactionReaction5.x__,
                "🚀" => ResponseNewMessageDataReactionReaction5.x__,
                "👀" => ResponseNewMessageDataReactionReaction5.x__,
                "❤️" => ResponseNewMessageDataReactionReaction5.x__,
                "🤗" => ResponseNewMessageDataReactionReaction5.x__,
                "😎" => ResponseNewMessageDataReactionReaction5.x__,
                "➕" => ResponseNewMessageDataReactionReaction5.x_,
                "🧠" => ResponseNewMessageDataReactionReaction5.x__,
                "👍" => ResponseNewMessageDataReactionReaction5.x__,
                "🤝" => ResponseNewMessageDataReactionReaction5.x__,
                "😔" => ResponseNewMessageDataReactionReaction5.x__,
                "🤯" => ResponseNewMessageDataReactionReaction5.x__,
                _ => null,
            };
        }
    }
}