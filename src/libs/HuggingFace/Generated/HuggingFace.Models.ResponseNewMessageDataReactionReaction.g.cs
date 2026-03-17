
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataReactionReaction
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
    public static class ResponseNewMessageDataReactionReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataReactionReaction value)
        {
            return value switch
            {
                ResponseNewMessageDataReactionReaction.x__ => "🔥",
                ResponseNewMessageDataReactionReaction.x__ => "🚀",
                ResponseNewMessageDataReactionReaction.x__ => "👀",
                ResponseNewMessageDataReactionReaction.x__ => "❤️",
                ResponseNewMessageDataReactionReaction.x__ => "🤗",
                ResponseNewMessageDataReactionReaction.x__ => "😎",
                ResponseNewMessageDataReactionReaction.x_ => "➕",
                ResponseNewMessageDataReactionReaction.x__ => "🧠",
                ResponseNewMessageDataReactionReaction.x__ => "👍",
                ResponseNewMessageDataReactionReaction.x__ => "🤝",
                ResponseNewMessageDataReactionReaction.x__ => "😔",
                ResponseNewMessageDataReactionReaction.x__ => "🤯",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataReactionReaction? ToEnum(string value)
        {
            return value switch
            {
                "🔥" => ResponseNewMessageDataReactionReaction.x__,
                "🚀" => ResponseNewMessageDataReactionReaction.x__,
                "👀" => ResponseNewMessageDataReactionReaction.x__,
                "❤️" => ResponseNewMessageDataReactionReaction.x__,
                "🤗" => ResponseNewMessageDataReactionReaction.x__,
                "😎" => ResponseNewMessageDataReactionReaction.x__,
                "➕" => ResponseNewMessageDataReactionReaction.x_,
                "🧠" => ResponseNewMessageDataReactionReaction.x__,
                "👍" => ResponseNewMessageDataReactionReaction.x__,
                "🤝" => ResponseNewMessageDataReactionReaction.x__,
                "😔" => ResponseNewMessageDataReactionReaction.x__,
                "🤯" => ResponseNewMessageDataReactionReaction.x__,
                _ => null,
            };
        }
    }
}