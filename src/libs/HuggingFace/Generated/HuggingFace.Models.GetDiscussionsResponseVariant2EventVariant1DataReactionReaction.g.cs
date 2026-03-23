
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseVariant2EventVariant1DataReactionReaction
    {
        /// <summary>
        /// 
        /// </summary>
        Brain,
        /// <summary>
        /// 
        /// </summary>
        Cool,
        /// <summary>
        /// 
        /// </summary>
        Eyes,
        /// <summary>
        /// 
        /// </summary>
        Fire,
        /// <summary>
        /// 
        /// </summary>
        Handshake,
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
        Mindblown,
        /// <summary>
        /// 
        /// </summary>
        Plus,
        /// <summary>
        /// 
        /// </summary>
        Rocket,
        /// <summary>
        /// 
        /// </summary>
        Sad,
        /// <summary>
        /// 
        /// </summary>
        Thumbsup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDiscussionsResponseVariant2EventVariant1DataReactionReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseVariant2EventVariant1DataReactionReaction value)
        {
            return value switch
            {
                GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Brain => "brain",
                GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Cool => "cool",
                GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Eyes => "eyes",
                GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Fire => "fire",
                GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Handshake => "handshake",
                GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Heart => "heart",
                GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Hugs => "hugs",
                GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Mindblown => "mindblown",
                GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Plus => "plus",
                GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Rocket => "rocket",
                GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Sad => "sad",
                GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Thumbsup => "thumbsup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseVariant2EventVariant1DataReactionReaction? ToEnum(string value)
        {
            return value switch
            {
                "brain" => GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Brain,
                "cool" => GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Cool,
                "eyes" => GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Eyes,
                "fire" => GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Fire,
                "handshake" => GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Handshake,
                "heart" => GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Heart,
                "hugs" => GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Hugs,
                "mindblown" => GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Mindblown,
                "plus" => GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Plus,
                "rocket" => GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Rocket,
                "sad" => GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Sad,
                "thumbsup" => GetDiscussionsResponseVariant2EventVariant1DataReactionReaction.Thumbsup,
                _ => null,
            };
        }
    }
}