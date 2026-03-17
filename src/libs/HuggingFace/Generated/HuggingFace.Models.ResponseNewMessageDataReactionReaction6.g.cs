
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
    public static class ResponseNewMessageDataReactionReaction6Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataReactionReaction6 value)
        {
            return value switch
            {
                ResponseNewMessageDataReactionReaction6.Fire => "fire",
                ResponseNewMessageDataReactionReaction6.Rocket => "rocket",
                ResponseNewMessageDataReactionReaction6.Eyes => "eyes",
                ResponseNewMessageDataReactionReaction6.Heart => "heart",
                ResponseNewMessageDataReactionReaction6.Hugs => "hugs",
                ResponseNewMessageDataReactionReaction6.Cool => "cool",
                ResponseNewMessageDataReactionReaction6.Plus => "plus",
                ResponseNewMessageDataReactionReaction6.Brain => "brain",
                ResponseNewMessageDataReactionReaction6.Thumbsup => "thumbsup",
                ResponseNewMessageDataReactionReaction6.Handshake => "handshake",
                ResponseNewMessageDataReactionReaction6.Sad => "sad",
                ResponseNewMessageDataReactionReaction6.Mindblown => "mindblown",
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
                "fire" => ResponseNewMessageDataReactionReaction6.Fire,
                "rocket" => ResponseNewMessageDataReactionReaction6.Rocket,
                "eyes" => ResponseNewMessageDataReactionReaction6.Eyes,
                "heart" => ResponseNewMessageDataReactionReaction6.Heart,
                "hugs" => ResponseNewMessageDataReactionReaction6.Hugs,
                "cool" => ResponseNewMessageDataReactionReaction6.Cool,
                "plus" => ResponseNewMessageDataReactionReaction6.Plus,
                "brain" => ResponseNewMessageDataReactionReaction6.Brain,
                "thumbsup" => ResponseNewMessageDataReactionReaction6.Thumbsup,
                "handshake" => ResponseNewMessageDataReactionReaction6.Handshake,
                "sad" => ResponseNewMessageDataReactionReaction6.Sad,
                "mindblown" => ResponseNewMessageDataReactionReaction6.Mindblown,
                _ => null,
            };
        }
    }
}