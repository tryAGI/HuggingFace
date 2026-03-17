
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
        Fire,
        /// <summary>
        /// 
        /// </summary>
        Rocket,
        /// <summary>
        /// 
        /// </summary>
        Eyes,
        /// <summary>
        /// 
        /// </summary>
        Heart,
        /// <summary>
        /// 
        /// </summary>
        Hugs,
        /// <summary>
        /// 
        /// </summary>
        Cool,
        /// <summary>
        /// 
        /// </summary>
        Plus,
        /// <summary>
        /// 
        /// </summary>
        Brain,
        /// <summary>
        /// 
        /// </summary>
        Thumbsup,
        /// <summary>
        /// 
        /// </summary>
        Handshake,
        /// <summary>
        /// 
        /// </summary>
        Sad,
        /// <summary>
        /// 
        /// </summary>
        Mindblown,
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
                ResponseVariant2EventVariant1DataReactionReaction.Fire => "fire",
                ResponseVariant2EventVariant1DataReactionReaction.Rocket => "rocket",
                ResponseVariant2EventVariant1DataReactionReaction.Eyes => "eyes",
                ResponseVariant2EventVariant1DataReactionReaction.Heart => "heart",
                ResponseVariant2EventVariant1DataReactionReaction.Hugs => "hugs",
                ResponseVariant2EventVariant1DataReactionReaction.Cool => "cool",
                ResponseVariant2EventVariant1DataReactionReaction.Plus => "plus",
                ResponseVariant2EventVariant1DataReactionReaction.Brain => "brain",
                ResponseVariant2EventVariant1DataReactionReaction.Thumbsup => "thumbsup",
                ResponseVariant2EventVariant1DataReactionReaction.Handshake => "handshake",
                ResponseVariant2EventVariant1DataReactionReaction.Sad => "sad",
                ResponseVariant2EventVariant1DataReactionReaction.Mindblown => "mindblown",
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
                "fire" => ResponseVariant2EventVariant1DataReactionReaction.Fire,
                "rocket" => ResponseVariant2EventVariant1DataReactionReaction.Rocket,
                "eyes" => ResponseVariant2EventVariant1DataReactionReaction.Eyes,
                "heart" => ResponseVariant2EventVariant1DataReactionReaction.Heart,
                "hugs" => ResponseVariant2EventVariant1DataReactionReaction.Hugs,
                "cool" => ResponseVariant2EventVariant1DataReactionReaction.Cool,
                "plus" => ResponseVariant2EventVariant1DataReactionReaction.Plus,
                "brain" => ResponseVariant2EventVariant1DataReactionReaction.Brain,
                "thumbsup" => ResponseVariant2EventVariant1DataReactionReaction.Thumbsup,
                "handshake" => ResponseVariant2EventVariant1DataReactionReaction.Handshake,
                "sad" => ResponseVariant2EventVariant1DataReactionReaction.Sad,
                "mindblown" => ResponseVariant2EventVariant1DataReactionReaction.Mindblown,
                _ => null,
            };
        }
    }
}