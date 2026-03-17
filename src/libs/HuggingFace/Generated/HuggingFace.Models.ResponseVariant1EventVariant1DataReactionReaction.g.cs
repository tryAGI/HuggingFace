
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
    public static class ResponseVariant1EventVariant1DataReactionReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseVariant1EventVariant1DataReactionReaction value)
        {
            return value switch
            {
                ResponseVariant1EventVariant1DataReactionReaction.Fire => "fire",
                ResponseVariant1EventVariant1DataReactionReaction.Rocket => "rocket",
                ResponseVariant1EventVariant1DataReactionReaction.Eyes => "eyes",
                ResponseVariant1EventVariant1DataReactionReaction.Heart => "heart",
                ResponseVariant1EventVariant1DataReactionReaction.Hugs => "hugs",
                ResponseVariant1EventVariant1DataReactionReaction.Cool => "cool",
                ResponseVariant1EventVariant1DataReactionReaction.Plus => "plus",
                ResponseVariant1EventVariant1DataReactionReaction.Brain => "brain",
                ResponseVariant1EventVariant1DataReactionReaction.Thumbsup => "thumbsup",
                ResponseVariant1EventVariant1DataReactionReaction.Handshake => "handshake",
                ResponseVariant1EventVariant1DataReactionReaction.Sad => "sad",
                ResponseVariant1EventVariant1DataReactionReaction.Mindblown => "mindblown",
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
                "fire" => ResponseVariant1EventVariant1DataReactionReaction.Fire,
                "rocket" => ResponseVariant1EventVariant1DataReactionReaction.Rocket,
                "eyes" => ResponseVariant1EventVariant1DataReactionReaction.Eyes,
                "heart" => ResponseVariant1EventVariant1DataReactionReaction.Heart,
                "hugs" => ResponseVariant1EventVariant1DataReactionReaction.Hugs,
                "cool" => ResponseVariant1EventVariant1DataReactionReaction.Cool,
                "plus" => ResponseVariant1EventVariant1DataReactionReaction.Plus,
                "brain" => ResponseVariant1EventVariant1DataReactionReaction.Brain,
                "thumbsup" => ResponseVariant1EventVariant1DataReactionReaction.Thumbsup,
                "handshake" => ResponseVariant1EventVariant1DataReactionReaction.Handshake,
                "sad" => ResponseVariant1EventVariant1DataReactionReaction.Sad,
                "mindblown" => ResponseVariant1EventVariant1DataReactionReaction.Mindblown,
                _ => null,
            };
        }
    }
}