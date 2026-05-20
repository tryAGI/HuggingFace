
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPapersResponseCommentDataReactionReaction
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
    public static class GetPapersResponseCommentDataReactionReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPapersResponseCommentDataReactionReaction value)
        {
            return value switch
            {
                GetPapersResponseCommentDataReactionReaction.Brain => "brain",
                GetPapersResponseCommentDataReactionReaction.Cool => "cool",
                GetPapersResponseCommentDataReactionReaction.Eyes => "eyes",
                GetPapersResponseCommentDataReactionReaction.Fire => "fire",
                GetPapersResponseCommentDataReactionReaction.Handshake => "handshake",
                GetPapersResponseCommentDataReactionReaction.Heart => "heart",
                GetPapersResponseCommentDataReactionReaction.Hugs => "hugs",
                GetPapersResponseCommentDataReactionReaction.Mindblown => "mindblown",
                GetPapersResponseCommentDataReactionReaction.Plus => "plus",
                GetPapersResponseCommentDataReactionReaction.Rocket => "rocket",
                GetPapersResponseCommentDataReactionReaction.Sad => "sad",
                GetPapersResponseCommentDataReactionReaction.Thumbsup => "thumbsup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPapersResponseCommentDataReactionReaction? ToEnum(string value)
        {
            return value switch
            {
                "brain" => GetPapersResponseCommentDataReactionReaction.Brain,
                "cool" => GetPapersResponseCommentDataReactionReaction.Cool,
                "eyes" => GetPapersResponseCommentDataReactionReaction.Eyes,
                "fire" => GetPapersResponseCommentDataReactionReaction.Fire,
                "handshake" => GetPapersResponseCommentDataReactionReaction.Handshake,
                "heart" => GetPapersResponseCommentDataReactionReaction.Heart,
                "hugs" => GetPapersResponseCommentDataReactionReaction.Hugs,
                "mindblown" => GetPapersResponseCommentDataReactionReaction.Mindblown,
                "plus" => GetPapersResponseCommentDataReactionReaction.Plus,
                "rocket" => GetPapersResponseCommentDataReactionReaction.Rocket,
                "sad" => GetPapersResponseCommentDataReactionReaction.Sad,
                "thumbsup" => GetPapersResponseCommentDataReactionReaction.Thumbsup,
                _ => null,
            };
        }
    }
}