
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataReactionReaction6
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
    public static class ResponseNewMessageDataReactionReaction6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataReactionReaction6 value)
        {
            return value switch
            {
                ResponseNewMessageDataReactionReaction6.x__ => "🔥",
                ResponseNewMessageDataReactionReaction6.x__ => "🚀",
                ResponseNewMessageDataReactionReaction6.x__ => "👀",
                ResponseNewMessageDataReactionReaction6.x__ => "❤️",
                ResponseNewMessageDataReactionReaction6.x__ => "🤗",
                ResponseNewMessageDataReactionReaction6.x__ => "😎",
                ResponseNewMessageDataReactionReaction6.x_ => "➕",
                ResponseNewMessageDataReactionReaction6.x__ => "🧠",
                ResponseNewMessageDataReactionReaction6.x__ => "👍",
                ResponseNewMessageDataReactionReaction6.x__ => "🤝",
                ResponseNewMessageDataReactionReaction6.x__ => "😔",
                ResponseNewMessageDataReactionReaction6.x__ => "🤯",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataReactionReaction6? ToEnum(string value)
        {
            return value switch
            {
                "🔥" => ResponseNewMessageDataReactionReaction6.x__,
                "🚀" => ResponseNewMessageDataReactionReaction6.x__,
                "👀" => ResponseNewMessageDataReactionReaction6.x__,
                "❤️" => ResponseNewMessageDataReactionReaction6.x__,
                "🤗" => ResponseNewMessageDataReactionReaction6.x__,
                "😎" => ResponseNewMessageDataReactionReaction6.x__,
                "➕" => ResponseNewMessageDataReactionReaction6.x_,
                "🧠" => ResponseNewMessageDataReactionReaction6.x__,
                "👍" => ResponseNewMessageDataReactionReaction6.x__,
                "🤝" => ResponseNewMessageDataReactionReaction6.x__,
                "😔" => ResponseNewMessageDataReactionReaction6.x__,
                "🤯" => ResponseNewMessageDataReactionReaction6.x__,
                _ => null,
            };
        }
    }
}