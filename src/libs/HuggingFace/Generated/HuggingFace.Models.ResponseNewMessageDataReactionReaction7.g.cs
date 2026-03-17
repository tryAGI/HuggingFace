
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataReactionReaction7
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
    public static class ResponseNewMessageDataReactionReaction7Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataReactionReaction7 value)
        {
            return value switch
            {
                ResponseNewMessageDataReactionReaction7.Fire => "fire",
                ResponseNewMessageDataReactionReaction7.Rocket => "rocket",
                ResponseNewMessageDataReactionReaction7.Eyes => "eyes",
                ResponseNewMessageDataReactionReaction7.Heart => "heart",
                ResponseNewMessageDataReactionReaction7.Hugs => "hugs",
                ResponseNewMessageDataReactionReaction7.Cool => "cool",
                ResponseNewMessageDataReactionReaction7.Plus => "plus",
                ResponseNewMessageDataReactionReaction7.Brain => "brain",
                ResponseNewMessageDataReactionReaction7.Thumbsup => "thumbsup",
                ResponseNewMessageDataReactionReaction7.Handshake => "handshake",
                ResponseNewMessageDataReactionReaction7.Sad => "sad",
                ResponseNewMessageDataReactionReaction7.Mindblown => "mindblown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataReactionReaction7? ToEnum(string value)
        {
            return value switch
            {
                "fire" => ResponseNewMessageDataReactionReaction7.Fire,
                "rocket" => ResponseNewMessageDataReactionReaction7.Rocket,
                "eyes" => ResponseNewMessageDataReactionReaction7.Eyes,
                "heart" => ResponseNewMessageDataReactionReaction7.Heart,
                "hugs" => ResponseNewMessageDataReactionReaction7.Hugs,
                "cool" => ResponseNewMessageDataReactionReaction7.Cool,
                "plus" => ResponseNewMessageDataReactionReaction7.Plus,
                "brain" => ResponseNewMessageDataReactionReaction7.Brain,
                "thumbsup" => ResponseNewMessageDataReactionReaction7.Thumbsup,
                "handshake" => ResponseNewMessageDataReactionReaction7.Handshake,
                "sad" => ResponseNewMessageDataReactionReaction7.Sad,
                "mindblown" => ResponseNewMessageDataReactionReaction7.Mindblown,
                _ => null,
            };
        }
    }
}