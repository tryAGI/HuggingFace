
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataReactionReaction8
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
    public static class ResponseNewMessageDataReactionReaction8Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataReactionReaction8 value)
        {
            return value switch
            {
                ResponseNewMessageDataReactionReaction8.Fire => "fire",
                ResponseNewMessageDataReactionReaction8.Rocket => "rocket",
                ResponseNewMessageDataReactionReaction8.Eyes => "eyes",
                ResponseNewMessageDataReactionReaction8.Heart => "heart",
                ResponseNewMessageDataReactionReaction8.Hugs => "hugs",
                ResponseNewMessageDataReactionReaction8.Cool => "cool",
                ResponseNewMessageDataReactionReaction8.Plus => "plus",
                ResponseNewMessageDataReactionReaction8.Brain => "brain",
                ResponseNewMessageDataReactionReaction8.Thumbsup => "thumbsup",
                ResponseNewMessageDataReactionReaction8.Handshake => "handshake",
                ResponseNewMessageDataReactionReaction8.Sad => "sad",
                ResponseNewMessageDataReactionReaction8.Mindblown => "mindblown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataReactionReaction8? ToEnum(string value)
        {
            return value switch
            {
                "fire" => ResponseNewMessageDataReactionReaction8.Fire,
                "rocket" => ResponseNewMessageDataReactionReaction8.Rocket,
                "eyes" => ResponseNewMessageDataReactionReaction8.Eyes,
                "heart" => ResponseNewMessageDataReactionReaction8.Heart,
                "hugs" => ResponseNewMessageDataReactionReaction8.Hugs,
                "cool" => ResponseNewMessageDataReactionReaction8.Cool,
                "plus" => ResponseNewMessageDataReactionReaction8.Plus,
                "brain" => ResponseNewMessageDataReactionReaction8.Brain,
                "thumbsup" => ResponseNewMessageDataReactionReaction8.Thumbsup,
                "handshake" => ResponseNewMessageDataReactionReaction8.Handshake,
                "sad" => ResponseNewMessageDataReactionReaction8.Sad,
                "mindblown" => ResponseNewMessageDataReactionReaction8.Mindblown,
                _ => null,
            };
        }
    }
}