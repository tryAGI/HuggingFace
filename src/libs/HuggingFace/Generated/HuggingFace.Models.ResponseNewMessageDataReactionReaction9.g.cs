
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseNewMessageDataReactionReaction9
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
    public static class ResponseNewMessageDataReactionReaction9Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseNewMessageDataReactionReaction9 value)
        {
            return value switch
            {
                ResponseNewMessageDataReactionReaction9.Fire => "fire",
                ResponseNewMessageDataReactionReaction9.Rocket => "rocket",
                ResponseNewMessageDataReactionReaction9.Eyes => "eyes",
                ResponseNewMessageDataReactionReaction9.Heart => "heart",
                ResponseNewMessageDataReactionReaction9.Hugs => "hugs",
                ResponseNewMessageDataReactionReaction9.Cool => "cool",
                ResponseNewMessageDataReactionReaction9.Plus => "plus",
                ResponseNewMessageDataReactionReaction9.Brain => "brain",
                ResponseNewMessageDataReactionReaction9.Thumbsup => "thumbsup",
                ResponseNewMessageDataReactionReaction9.Handshake => "handshake",
                ResponseNewMessageDataReactionReaction9.Sad => "sad",
                ResponseNewMessageDataReactionReaction9.Mindblown => "mindblown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseNewMessageDataReactionReaction9? ToEnum(string value)
        {
            return value switch
            {
                "fire" => ResponseNewMessageDataReactionReaction9.Fire,
                "rocket" => ResponseNewMessageDataReactionReaction9.Rocket,
                "eyes" => ResponseNewMessageDataReactionReaction9.Eyes,
                "heart" => ResponseNewMessageDataReactionReaction9.Heart,
                "hugs" => ResponseNewMessageDataReactionReaction9.Hugs,
                "cool" => ResponseNewMessageDataReactionReaction9.Cool,
                "plus" => ResponseNewMessageDataReactionReaction9.Plus,
                "brain" => ResponseNewMessageDataReactionReaction9.Brain,
                "thumbsup" => ResponseNewMessageDataReactionReaction9.Thumbsup,
                "handshake" => ResponseNewMessageDataReactionReaction9.Handshake,
                "sad" => ResponseNewMessageDataReactionReaction9.Sad,
                "mindblown" => ResponseNewMessageDataReactionReaction9.Mindblown,
                _ => null,
            };
        }
    }
}