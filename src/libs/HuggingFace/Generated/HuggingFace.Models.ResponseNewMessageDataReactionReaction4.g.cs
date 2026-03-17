
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataReactionReaction4
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
    public static class ResponseNewMessageDataReactionReaction4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataReactionReaction4 value)
        {
            return value switch
            {
                ResponseNewMessageDataReactionReaction4.x__ => "🔥",
                ResponseNewMessageDataReactionReaction4.x__ => "🚀",
                ResponseNewMessageDataReactionReaction4.x__ => "👀",
                ResponseNewMessageDataReactionReaction4.x__ => "❤️",
                ResponseNewMessageDataReactionReaction4.x__ => "🤗",
                ResponseNewMessageDataReactionReaction4.x__ => "😎",
                ResponseNewMessageDataReactionReaction4.x_ => "➕",
                ResponseNewMessageDataReactionReaction4.x__ => "🧠",
                ResponseNewMessageDataReactionReaction4.x__ => "👍",
                ResponseNewMessageDataReactionReaction4.x__ => "🤝",
                ResponseNewMessageDataReactionReaction4.x__ => "😔",
                ResponseNewMessageDataReactionReaction4.x__ => "🤯",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataReactionReaction4? ToEnum(string value)
        {
            return value switch
            {
                "🔥" => ResponseNewMessageDataReactionReaction4.x__,
                "🚀" => ResponseNewMessageDataReactionReaction4.x__,
                "👀" => ResponseNewMessageDataReactionReaction4.x__,
                "❤️" => ResponseNewMessageDataReactionReaction4.x__,
                "🤗" => ResponseNewMessageDataReactionReaction4.x__,
                "😎" => ResponseNewMessageDataReactionReaction4.x__,
                "➕" => ResponseNewMessageDataReactionReaction4.x_,
                "🧠" => ResponseNewMessageDataReactionReaction4.x__,
                "👍" => ResponseNewMessageDataReactionReaction4.x__,
                "🤝" => ResponseNewMessageDataReactionReaction4.x__,
                "😔" => ResponseNewMessageDataReactionReaction4.x__,
                "🤯" => ResponseNewMessageDataReactionReaction4.x__,
                _ => null,
            };
        }
    }
}