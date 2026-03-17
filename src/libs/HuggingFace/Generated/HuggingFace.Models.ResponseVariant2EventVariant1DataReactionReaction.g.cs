
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseVariant2EventVariant1DataReactionReaction
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
    public static class ResponseVariant2EventVariant1DataReactionReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant2EventVariant1DataReactionReaction value)
        {
            return value switch
            {
                ResponseVariant2EventVariant1DataReactionReaction.x__ => "🔥",
                ResponseVariant2EventVariant1DataReactionReaction.x__ => "🚀",
                ResponseVariant2EventVariant1DataReactionReaction.x__ => "👀",
                ResponseVariant2EventVariant1DataReactionReaction.x__ => "❤️",
                ResponseVariant2EventVariant1DataReactionReaction.x__ => "🤗",
                ResponseVariant2EventVariant1DataReactionReaction.x__ => "😎",
                ResponseVariant2EventVariant1DataReactionReaction.x_ => "➕",
                ResponseVariant2EventVariant1DataReactionReaction.x__ => "🧠",
                ResponseVariant2EventVariant1DataReactionReaction.x__ => "👍",
                ResponseVariant2EventVariant1DataReactionReaction.x__ => "🤝",
                ResponseVariant2EventVariant1DataReactionReaction.x__ => "😔",
                ResponseVariant2EventVariant1DataReactionReaction.x__ => "🤯",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseVariant2EventVariant1DataReactionReaction? ToEnum(string value)
        {
            return value switch
            {
                "🔥" => ResponseVariant2EventVariant1DataReactionReaction.x__,
                "🚀" => ResponseVariant2EventVariant1DataReactionReaction.x__,
                "👀" => ResponseVariant2EventVariant1DataReactionReaction.x__,
                "❤️" => ResponseVariant2EventVariant1DataReactionReaction.x__,
                "🤗" => ResponseVariant2EventVariant1DataReactionReaction.x__,
                "😎" => ResponseVariant2EventVariant1DataReactionReaction.x__,
                "➕" => ResponseVariant2EventVariant1DataReactionReaction.x_,
                "🧠" => ResponseVariant2EventVariant1DataReactionReaction.x__,
                "👍" => ResponseVariant2EventVariant1DataReactionReaction.x__,
                "🤝" => ResponseVariant2EventVariant1DataReactionReaction.x__,
                "😔" => ResponseVariant2EventVariant1DataReactionReaction.x__,
                "🤯" => ResponseVariant2EventVariant1DataReactionReaction.x__,
                _ => null,
            };
        }
    }
}