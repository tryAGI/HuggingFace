
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataReactionReaction4
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
    public static class ResponseNewMessageDataReactionReaction4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataReactionReaction4 value)
        {
            return value switch
            {
                ResponseNewMessageDataReactionReaction4.Fire => "fire",
                ResponseNewMessageDataReactionReaction4.Rocket => "rocket",
                ResponseNewMessageDataReactionReaction4.Eyes => "eyes",
                ResponseNewMessageDataReactionReaction4.Heart => "heart",
                ResponseNewMessageDataReactionReaction4.Hugs => "hugs",
                ResponseNewMessageDataReactionReaction4.Cool => "cool",
                ResponseNewMessageDataReactionReaction4.Plus => "plus",
                ResponseNewMessageDataReactionReaction4.Brain => "brain",
                ResponseNewMessageDataReactionReaction4.Thumbsup => "thumbsup",
                ResponseNewMessageDataReactionReaction4.Handshake => "handshake",
                ResponseNewMessageDataReactionReaction4.Sad => "sad",
                ResponseNewMessageDataReactionReaction4.Mindblown => "mindblown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataReactionReaction4? ToEnum(string value)
        {
            return value switch
            {
                "fire" => ResponseNewMessageDataReactionReaction4.Fire,
                "rocket" => ResponseNewMessageDataReactionReaction4.Rocket,
                "eyes" => ResponseNewMessageDataReactionReaction4.Eyes,
                "heart" => ResponseNewMessageDataReactionReaction4.Heart,
                "hugs" => ResponseNewMessageDataReactionReaction4.Hugs,
                "cool" => ResponseNewMessageDataReactionReaction4.Cool,
                "plus" => ResponseNewMessageDataReactionReaction4.Plus,
                "brain" => ResponseNewMessageDataReactionReaction4.Brain,
                "thumbsup" => ResponseNewMessageDataReactionReaction4.Thumbsup,
                "handshake" => ResponseNewMessageDataReactionReaction4.Handshake,
                "sad" => ResponseNewMessageDataReactionReaction4.Sad,
                "mindblown" => ResponseNewMessageDataReactionReaction4.Mindblown,
                _ => null,
            };
        }
    }
}