
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataReactionReaction3
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
    public static class ResponseNewMessageDataReactionReaction3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataReactionReaction3 value)
        {
            return value switch
            {
                ResponseNewMessageDataReactionReaction3.x__ => "🔥",
                ResponseNewMessageDataReactionReaction3.x__ => "🚀",
                ResponseNewMessageDataReactionReaction3.x__ => "👀",
                ResponseNewMessageDataReactionReaction3.x__ => "❤️",
                ResponseNewMessageDataReactionReaction3.x__ => "🤗",
                ResponseNewMessageDataReactionReaction3.x__ => "😎",
                ResponseNewMessageDataReactionReaction3.x_ => "➕",
                ResponseNewMessageDataReactionReaction3.x__ => "🧠",
                ResponseNewMessageDataReactionReaction3.x__ => "👍",
                ResponseNewMessageDataReactionReaction3.x__ => "🤝",
                ResponseNewMessageDataReactionReaction3.x__ => "😔",
                ResponseNewMessageDataReactionReaction3.x__ => "🤯",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataReactionReaction3? ToEnum(string value)
        {
            return value switch
            {
                "🔥" => ResponseNewMessageDataReactionReaction3.x__,
                "🚀" => ResponseNewMessageDataReactionReaction3.x__,
                "👀" => ResponseNewMessageDataReactionReaction3.x__,
                "❤️" => ResponseNewMessageDataReactionReaction3.x__,
                "🤗" => ResponseNewMessageDataReactionReaction3.x__,
                "😎" => ResponseNewMessageDataReactionReaction3.x__,
                "➕" => ResponseNewMessageDataReactionReaction3.x_,
                "🧠" => ResponseNewMessageDataReactionReaction3.x__,
                "👍" => ResponseNewMessageDataReactionReaction3.x__,
                "🤝" => ResponseNewMessageDataReactionReaction3.x__,
                "😔" => ResponseNewMessageDataReactionReaction3.x__,
                "🤯" => ResponseNewMessageDataReactionReaction3.x__,
                _ => null,
            };
        }
    }
}