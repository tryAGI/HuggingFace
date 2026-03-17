
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataReactionReaction7
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
    public static class ResponseNewMessageDataReactionReaction7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataReactionReaction7 value)
        {
            return value switch
            {
                ResponseNewMessageDataReactionReaction7.x__ => "🔥",
                ResponseNewMessageDataReactionReaction7.x__ => "🚀",
                ResponseNewMessageDataReactionReaction7.x__ => "👀",
                ResponseNewMessageDataReactionReaction7.x__ => "❤️",
                ResponseNewMessageDataReactionReaction7.x__ => "🤗",
                ResponseNewMessageDataReactionReaction7.x__ => "😎",
                ResponseNewMessageDataReactionReaction7.x_ => "➕",
                ResponseNewMessageDataReactionReaction7.x__ => "🧠",
                ResponseNewMessageDataReactionReaction7.x__ => "👍",
                ResponseNewMessageDataReactionReaction7.x__ => "🤝",
                ResponseNewMessageDataReactionReaction7.x__ => "😔",
                ResponseNewMessageDataReactionReaction7.x__ => "🤯",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataReactionReaction7? ToEnum(string value)
        {
            return value switch
            {
                "🔥" => ResponseNewMessageDataReactionReaction7.x__,
                "🚀" => ResponseNewMessageDataReactionReaction7.x__,
                "👀" => ResponseNewMessageDataReactionReaction7.x__,
                "❤️" => ResponseNewMessageDataReactionReaction7.x__,
                "🤗" => ResponseNewMessageDataReactionReaction7.x__,
                "😎" => ResponseNewMessageDataReactionReaction7.x__,
                "➕" => ResponseNewMessageDataReactionReaction7.x_,
                "🧠" => ResponseNewMessageDataReactionReaction7.x__,
                "👍" => ResponseNewMessageDataReactionReaction7.x__,
                "🤝" => ResponseNewMessageDataReactionReaction7.x__,
                "😔" => ResponseNewMessageDataReactionReaction7.x__,
                "🤯" => ResponseNewMessageDataReactionReaction7.x__,
                _ => null,
            };
        }
    }
}