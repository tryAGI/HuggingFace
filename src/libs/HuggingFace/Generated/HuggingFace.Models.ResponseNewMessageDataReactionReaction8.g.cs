
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataReactionReaction8
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
    public static class ResponseNewMessageDataReactionReaction8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataReactionReaction8 value)
        {
            return value switch
            {
                ResponseNewMessageDataReactionReaction8.x__ => "🔥",
                ResponseNewMessageDataReactionReaction8.x__ => "🚀",
                ResponseNewMessageDataReactionReaction8.x__ => "👀",
                ResponseNewMessageDataReactionReaction8.x__ => "❤️",
                ResponseNewMessageDataReactionReaction8.x__ => "🤗",
                ResponseNewMessageDataReactionReaction8.x__ => "😎",
                ResponseNewMessageDataReactionReaction8.x_ => "➕",
                ResponseNewMessageDataReactionReaction8.x__ => "🧠",
                ResponseNewMessageDataReactionReaction8.x__ => "👍",
                ResponseNewMessageDataReactionReaction8.x__ => "🤝",
                ResponseNewMessageDataReactionReaction8.x__ => "😔",
                ResponseNewMessageDataReactionReaction8.x__ => "🤯",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataReactionReaction8? ToEnum(string value)
        {
            return value switch
            {
                "🔥" => ResponseNewMessageDataReactionReaction8.x__,
                "🚀" => ResponseNewMessageDataReactionReaction8.x__,
                "👀" => ResponseNewMessageDataReactionReaction8.x__,
                "❤️" => ResponseNewMessageDataReactionReaction8.x__,
                "🤗" => ResponseNewMessageDataReactionReaction8.x__,
                "😎" => ResponseNewMessageDataReactionReaction8.x__,
                "➕" => ResponseNewMessageDataReactionReaction8.x_,
                "🧠" => ResponseNewMessageDataReactionReaction8.x__,
                "👍" => ResponseNewMessageDataReactionReaction8.x__,
                "🤝" => ResponseNewMessageDataReactionReaction8.x__,
                "😔" => ResponseNewMessageDataReactionReaction8.x__,
                "🤯" => ResponseNewMessageDataReactionReaction8.x__,
                _ => null,
            };
        }
    }
}