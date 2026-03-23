
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseVariant1EventVariant1DataReactionReaction
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
    public static class GetDiscussionsResponseVariant1EventVariant1DataReactionReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseVariant1EventVariant1DataReactionReaction value)
        {
            return value switch
            {
                GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Brain => "brain",
                GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Cool => "cool",
                GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Eyes => "eyes",
                GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Fire => "fire",
                GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Handshake => "handshake",
                GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Heart => "heart",
                GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Hugs => "hugs",
                GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Mindblown => "mindblown",
                GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Plus => "plus",
                GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Rocket => "rocket",
                GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Sad => "sad",
                GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Thumbsup => "thumbsup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseVariant1EventVariant1DataReactionReaction? ToEnum(string value)
        {
            return value switch
            {
                "brain" => GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Brain,
                "cool" => GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Cool,
                "eyes" => GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Eyes,
                "fire" => GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Fire,
                "handshake" => GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Handshake,
                "heart" => GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Heart,
                "hugs" => GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Hugs,
                "mindblown" => GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Mindblown,
                "plus" => GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Plus,
                "rocket" => GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Rocket,
                "sad" => GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Sad,
                "thumbsup" => GetDiscussionsResponseVariant1EventVariant1DataReactionReaction.Thumbsup,
                _ => null,
            };
        }
    }
}