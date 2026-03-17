
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataReactionReaction
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
    public static class ResponseNewMessageDataReactionReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataReactionReaction value)
        {
            return value switch
            {
                ResponseNewMessageDataReactionReaction.Fire => "fire",
                ResponseNewMessageDataReactionReaction.Rocket => "rocket",
                ResponseNewMessageDataReactionReaction.Eyes => "eyes",
                ResponseNewMessageDataReactionReaction.Heart => "heart",
                ResponseNewMessageDataReactionReaction.Hugs => "hugs",
                ResponseNewMessageDataReactionReaction.Cool => "cool",
                ResponseNewMessageDataReactionReaction.Plus => "plus",
                ResponseNewMessageDataReactionReaction.Brain => "brain",
                ResponseNewMessageDataReactionReaction.Thumbsup => "thumbsup",
                ResponseNewMessageDataReactionReaction.Handshake => "handshake",
                ResponseNewMessageDataReactionReaction.Sad => "sad",
                ResponseNewMessageDataReactionReaction.Mindblown => "mindblown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataReactionReaction? ToEnum(string value)
        {
            return value switch
            {
                "fire" => ResponseNewMessageDataReactionReaction.Fire,
                "rocket" => ResponseNewMessageDataReactionReaction.Rocket,
                "eyes" => ResponseNewMessageDataReactionReaction.Eyes,
                "heart" => ResponseNewMessageDataReactionReaction.Heart,
                "hugs" => ResponseNewMessageDataReactionReaction.Hugs,
                "cool" => ResponseNewMessageDataReactionReaction.Cool,
                "plus" => ResponseNewMessageDataReactionReaction.Plus,
                "brain" => ResponseNewMessageDataReactionReaction.Brain,
                "thumbsup" => ResponseNewMessageDataReactionReaction.Thumbsup,
                "handshake" => ResponseNewMessageDataReactionReaction.Handshake,
                "sad" => ResponseNewMessageDataReactionReaction.Sad,
                "mindblown" => ResponseNewMessageDataReactionReaction.Mindblown,
                _ => null,
            };
        }
    }
}