
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataReactionReaction5
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
    public static class ResponseNewMessageDataReactionReaction5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataReactionReaction5 value)
        {
            return value switch
            {
                ResponseNewMessageDataReactionReaction5.Fire => "fire",
                ResponseNewMessageDataReactionReaction5.Rocket => "rocket",
                ResponseNewMessageDataReactionReaction5.Eyes => "eyes",
                ResponseNewMessageDataReactionReaction5.Heart => "heart",
                ResponseNewMessageDataReactionReaction5.Hugs => "hugs",
                ResponseNewMessageDataReactionReaction5.Cool => "cool",
                ResponseNewMessageDataReactionReaction5.Plus => "plus",
                ResponseNewMessageDataReactionReaction5.Brain => "brain",
                ResponseNewMessageDataReactionReaction5.Thumbsup => "thumbsup",
                ResponseNewMessageDataReactionReaction5.Handshake => "handshake",
                ResponseNewMessageDataReactionReaction5.Sad => "sad",
                ResponseNewMessageDataReactionReaction5.Mindblown => "mindblown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataReactionReaction5? ToEnum(string value)
        {
            return value switch
            {
                "fire" => ResponseNewMessageDataReactionReaction5.Fire,
                "rocket" => ResponseNewMessageDataReactionReaction5.Rocket,
                "eyes" => ResponseNewMessageDataReactionReaction5.Eyes,
                "heart" => ResponseNewMessageDataReactionReaction5.Heart,
                "hugs" => ResponseNewMessageDataReactionReaction5.Hugs,
                "cool" => ResponseNewMessageDataReactionReaction5.Cool,
                "plus" => ResponseNewMessageDataReactionReaction5.Plus,
                "brain" => ResponseNewMessageDataReactionReaction5.Brain,
                "thumbsup" => ResponseNewMessageDataReactionReaction5.Thumbsup,
                "handshake" => ResponseNewMessageDataReactionReaction5.Handshake,
                "sad" => ResponseNewMessageDataReactionReaction5.Sad,
                "mindblown" => ResponseNewMessageDataReactionReaction5.Mindblown,
                _ => null,
            };
        }
    }
}