
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDiscussionTopReactionReaction
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
    public static class ResponseDiscussionTopReactionReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDiscussionTopReactionReaction value)
        {
            return value switch
            {
                ResponseDiscussionTopReactionReaction.Fire => "fire",
                ResponseDiscussionTopReactionReaction.Rocket => "rocket",
                ResponseDiscussionTopReactionReaction.Eyes => "eyes",
                ResponseDiscussionTopReactionReaction.Heart => "heart",
                ResponseDiscussionTopReactionReaction.Hugs => "hugs",
                ResponseDiscussionTopReactionReaction.Cool => "cool",
                ResponseDiscussionTopReactionReaction.Plus => "plus",
                ResponseDiscussionTopReactionReaction.Brain => "brain",
                ResponseDiscussionTopReactionReaction.Thumbsup => "thumbsup",
                ResponseDiscussionTopReactionReaction.Handshake => "handshake",
                ResponseDiscussionTopReactionReaction.Sad => "sad",
                ResponseDiscussionTopReactionReaction.Mindblown => "mindblown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDiscussionTopReactionReaction? ToEnum(string value)
        {
            return value switch
            {
                "fire" => ResponseDiscussionTopReactionReaction.Fire,
                "rocket" => ResponseDiscussionTopReactionReaction.Rocket,
                "eyes" => ResponseDiscussionTopReactionReaction.Eyes,
                "heart" => ResponseDiscussionTopReactionReaction.Heart,
                "hugs" => ResponseDiscussionTopReactionReaction.Hugs,
                "cool" => ResponseDiscussionTopReactionReaction.Cool,
                "plus" => ResponseDiscussionTopReactionReaction.Plus,
                "brain" => ResponseDiscussionTopReactionReaction.Brain,
                "thumbsup" => ResponseDiscussionTopReactionReaction.Thumbsup,
                "handshake" => ResponseDiscussionTopReactionReaction.Handshake,
                "sad" => ResponseDiscussionTopReactionReaction.Sad,
                "mindblown" => ResponseDiscussionTopReactionReaction.Mindblown,
                _ => null,
            };
        }
    }
}