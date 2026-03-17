
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataReactionReaction2
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
    public static class ResponseNewMessageDataReactionReaction2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataReactionReaction2 value)
        {
            return value switch
            {
                ResponseNewMessageDataReactionReaction2.Fire => "fire",
                ResponseNewMessageDataReactionReaction2.Rocket => "rocket",
                ResponseNewMessageDataReactionReaction2.Eyes => "eyes",
                ResponseNewMessageDataReactionReaction2.Heart => "heart",
                ResponseNewMessageDataReactionReaction2.Hugs => "hugs",
                ResponseNewMessageDataReactionReaction2.Cool => "cool",
                ResponseNewMessageDataReactionReaction2.Plus => "plus",
                ResponseNewMessageDataReactionReaction2.Brain => "brain",
                ResponseNewMessageDataReactionReaction2.Thumbsup => "thumbsup",
                ResponseNewMessageDataReactionReaction2.Handshake => "handshake",
                ResponseNewMessageDataReactionReaction2.Sad => "sad",
                ResponseNewMessageDataReactionReaction2.Mindblown => "mindblown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataReactionReaction2? ToEnum(string value)
        {
            return value switch
            {
                "fire" => ResponseNewMessageDataReactionReaction2.Fire,
                "rocket" => ResponseNewMessageDataReactionReaction2.Rocket,
                "eyes" => ResponseNewMessageDataReactionReaction2.Eyes,
                "heart" => ResponseNewMessageDataReactionReaction2.Heart,
                "hugs" => ResponseNewMessageDataReactionReaction2.Hugs,
                "cool" => ResponseNewMessageDataReactionReaction2.Cool,
                "plus" => ResponseNewMessageDataReactionReaction2.Plus,
                "brain" => ResponseNewMessageDataReactionReaction2.Brain,
                "thumbsup" => ResponseNewMessageDataReactionReaction2.Thumbsup,
                "handshake" => ResponseNewMessageDataReactionReaction2.Handshake,
                "sad" => ResponseNewMessageDataReactionReaction2.Sad,
                "mindblown" => ResponseNewMessageDataReactionReaction2.Mindblown,
                _ => null,
            };
        }
    }
}