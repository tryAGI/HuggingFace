
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataReactionReaction9
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
    public static class ResponseNewMessageDataReactionReaction9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataReactionReaction9 value)
        {
            return value switch
            {
                ResponseNewMessageDataReactionReaction9.x__ => "🔥",
                ResponseNewMessageDataReactionReaction9.x__ => "🚀",
                ResponseNewMessageDataReactionReaction9.x__ => "👀",
                ResponseNewMessageDataReactionReaction9.x__ => "❤️",
                ResponseNewMessageDataReactionReaction9.x__ => "🤗",
                ResponseNewMessageDataReactionReaction9.x__ => "😎",
                ResponseNewMessageDataReactionReaction9.x_ => "➕",
                ResponseNewMessageDataReactionReaction9.x__ => "🧠",
                ResponseNewMessageDataReactionReaction9.x__ => "👍",
                ResponseNewMessageDataReactionReaction9.x__ => "🤝",
                ResponseNewMessageDataReactionReaction9.x__ => "😔",
                ResponseNewMessageDataReactionReaction9.x__ => "🤯",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataReactionReaction9? ToEnum(string value)
        {
            return value switch
            {
                "🔥" => ResponseNewMessageDataReactionReaction9.x__,
                "🚀" => ResponseNewMessageDataReactionReaction9.x__,
                "👀" => ResponseNewMessageDataReactionReaction9.x__,
                "❤️" => ResponseNewMessageDataReactionReaction9.x__,
                "🤗" => ResponseNewMessageDataReactionReaction9.x__,
                "😎" => ResponseNewMessageDataReactionReaction9.x__,
                "➕" => ResponseNewMessageDataReactionReaction9.x_,
                "🧠" => ResponseNewMessageDataReactionReaction9.x__,
                "👍" => ResponseNewMessageDataReactionReaction9.x__,
                "🤝" => ResponseNewMessageDataReactionReaction9.x__,
                "😔" => ResponseNewMessageDataReactionReaction9.x__,
                "🤯" => ResponseNewMessageDataReactionReaction9.x__,
                _ => null,
            };
        }
    }
}