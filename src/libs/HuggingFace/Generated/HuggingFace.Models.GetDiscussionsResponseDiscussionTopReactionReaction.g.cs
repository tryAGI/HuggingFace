
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDiscussionsResponseDiscussionTopReactionReaction
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
    public static class GetDiscussionsResponseDiscussionTopReactionReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDiscussionsResponseDiscussionTopReactionReaction value)
        {
            return value switch
            {
                GetDiscussionsResponseDiscussionTopReactionReaction.Brain => "brain",
                GetDiscussionsResponseDiscussionTopReactionReaction.Cool => "cool",
                GetDiscussionsResponseDiscussionTopReactionReaction.Eyes => "eyes",
                GetDiscussionsResponseDiscussionTopReactionReaction.Fire => "fire",
                GetDiscussionsResponseDiscussionTopReactionReaction.Handshake => "handshake",
                GetDiscussionsResponseDiscussionTopReactionReaction.Heart => "heart",
                GetDiscussionsResponseDiscussionTopReactionReaction.Hugs => "hugs",
                GetDiscussionsResponseDiscussionTopReactionReaction.Mindblown => "mindblown",
                GetDiscussionsResponseDiscussionTopReactionReaction.Plus => "plus",
                GetDiscussionsResponseDiscussionTopReactionReaction.Rocket => "rocket",
                GetDiscussionsResponseDiscussionTopReactionReaction.Sad => "sad",
                GetDiscussionsResponseDiscussionTopReactionReaction.Thumbsup => "thumbsup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDiscussionsResponseDiscussionTopReactionReaction? ToEnum(string value)
        {
            return value switch
            {
                "brain" => GetDiscussionsResponseDiscussionTopReactionReaction.Brain,
                "cool" => GetDiscussionsResponseDiscussionTopReactionReaction.Cool,
                "eyes" => GetDiscussionsResponseDiscussionTopReactionReaction.Eyes,
                "fire" => GetDiscussionsResponseDiscussionTopReactionReaction.Fire,
                "handshake" => GetDiscussionsResponseDiscussionTopReactionReaction.Handshake,
                "heart" => GetDiscussionsResponseDiscussionTopReactionReaction.Heart,
                "hugs" => GetDiscussionsResponseDiscussionTopReactionReaction.Hugs,
                "mindblown" => GetDiscussionsResponseDiscussionTopReactionReaction.Mindblown,
                "plus" => GetDiscussionsResponseDiscussionTopReactionReaction.Plus,
                "rocket" => GetDiscussionsResponseDiscussionTopReactionReaction.Rocket,
                "sad" => GetDiscussionsResponseDiscussionTopReactionReaction.Sad,
                "thumbsup" => GetDiscussionsResponseDiscussionTopReactionReaction.Thumbsup,
                _ => null,
            };
        }
    }
}