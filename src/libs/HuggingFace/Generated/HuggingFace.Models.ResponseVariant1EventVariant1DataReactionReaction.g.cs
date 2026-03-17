
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant1EventVariant1DataReactionReaction
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
    public static class ResponseVariant1EventVariant1DataReactionReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1EventVariant1DataReactionReaction value)
        {
            return value switch
            {
                ResponseVariant1EventVariant1DataReactionReaction.x__ => "🔥",
                ResponseVariant1EventVariant1DataReactionReaction.x__ => "🚀",
                ResponseVariant1EventVariant1DataReactionReaction.x__ => "👀",
                ResponseVariant1EventVariant1DataReactionReaction.x__ => "❤️",
                ResponseVariant1EventVariant1DataReactionReaction.x__ => "🤗",
                ResponseVariant1EventVariant1DataReactionReaction.x__ => "😎",
                ResponseVariant1EventVariant1DataReactionReaction.x_ => "➕",
                ResponseVariant1EventVariant1DataReactionReaction.x__ => "🧠",
                ResponseVariant1EventVariant1DataReactionReaction.x__ => "👍",
                ResponseVariant1EventVariant1DataReactionReaction.x__ => "🤝",
                ResponseVariant1EventVariant1DataReactionReaction.x__ => "😔",
                ResponseVariant1EventVariant1DataReactionReaction.x__ => "🤯",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant1EventVariant1DataReactionReaction? ToEnum(string value)
        {
            return value switch
            {
                "🔥" => ResponseVariant1EventVariant1DataReactionReaction.x__,
                "🚀" => ResponseVariant1EventVariant1DataReactionReaction.x__,
                "👀" => ResponseVariant1EventVariant1DataReactionReaction.x__,
                "❤️" => ResponseVariant1EventVariant1DataReactionReaction.x__,
                "🤗" => ResponseVariant1EventVariant1DataReactionReaction.x__,
                "😎" => ResponseVariant1EventVariant1DataReactionReaction.x__,
                "➕" => ResponseVariant1EventVariant1DataReactionReaction.x_,
                "🧠" => ResponseVariant1EventVariant1DataReactionReaction.x__,
                "👍" => ResponseVariant1EventVariant1DataReactionReaction.x__,
                "🤝" => ResponseVariant1EventVariant1DataReactionReaction.x__,
                "😔" => ResponseVariant1EventVariant1DataReactionReaction.x__,
                "🤯" => ResponseVariant1EventVariant1DataReactionReaction.x__,
                _ => null,
            };
        }
    }
}