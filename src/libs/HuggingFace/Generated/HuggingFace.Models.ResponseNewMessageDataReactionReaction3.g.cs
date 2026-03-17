
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataReactionReaction3
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
    public static class ResponseNewMessageDataReactionReaction3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataReactionReaction3 value)
        {
            return value switch
            {
                ResponseNewMessageDataReactionReaction3.Fire => "fire",
                ResponseNewMessageDataReactionReaction3.Rocket => "rocket",
                ResponseNewMessageDataReactionReaction3.Eyes => "eyes",
                ResponseNewMessageDataReactionReaction3.Heart => "heart",
                ResponseNewMessageDataReactionReaction3.Hugs => "hugs",
                ResponseNewMessageDataReactionReaction3.Cool => "cool",
                ResponseNewMessageDataReactionReaction3.Plus => "plus",
                ResponseNewMessageDataReactionReaction3.Brain => "brain",
                ResponseNewMessageDataReactionReaction3.Thumbsup => "thumbsup",
                ResponseNewMessageDataReactionReaction3.Handshake => "handshake",
                ResponseNewMessageDataReactionReaction3.Sad => "sad",
                ResponseNewMessageDataReactionReaction3.Mindblown => "mindblown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataReactionReaction3? ToEnum(string value)
        {
            return value switch
            {
                "fire" => ResponseNewMessageDataReactionReaction3.Fire,
                "rocket" => ResponseNewMessageDataReactionReaction3.Rocket,
                "eyes" => ResponseNewMessageDataReactionReaction3.Eyes,
                "heart" => ResponseNewMessageDataReactionReaction3.Heart,
                "hugs" => ResponseNewMessageDataReactionReaction3.Hugs,
                "cool" => ResponseNewMessageDataReactionReaction3.Cool,
                "plus" => ResponseNewMessageDataReactionReaction3.Plus,
                "brain" => ResponseNewMessageDataReactionReaction3.Brain,
                "thumbsup" => ResponseNewMessageDataReactionReaction3.Thumbsup,
                "handshake" => ResponseNewMessageDataReactionReaction3.Handshake,
                "sad" => ResponseNewMessageDataReactionReaction3.Sad,
                "mindblown" => ResponseNewMessageDataReactionReaction3.Mindblown,
                _ => null,
            };
        }
    }
}