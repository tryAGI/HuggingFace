
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePostsCommentResponseNewMessageDataReactionReaction
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
    public static class CreatePostsCommentResponseNewMessageDataReactionReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePostsCommentResponseNewMessageDataReactionReaction value)
        {
            return value switch
            {
                CreatePostsCommentResponseNewMessageDataReactionReaction.Brain => "brain",
                CreatePostsCommentResponseNewMessageDataReactionReaction.Cool => "cool",
                CreatePostsCommentResponseNewMessageDataReactionReaction.Eyes => "eyes",
                CreatePostsCommentResponseNewMessageDataReactionReaction.Fire => "fire",
                CreatePostsCommentResponseNewMessageDataReactionReaction.Handshake => "handshake",
                CreatePostsCommentResponseNewMessageDataReactionReaction.Heart => "heart",
                CreatePostsCommentResponseNewMessageDataReactionReaction.Hugs => "hugs",
                CreatePostsCommentResponseNewMessageDataReactionReaction.Mindblown => "mindblown",
                CreatePostsCommentResponseNewMessageDataReactionReaction.Plus => "plus",
                CreatePostsCommentResponseNewMessageDataReactionReaction.Rocket => "rocket",
                CreatePostsCommentResponseNewMessageDataReactionReaction.Sad => "sad",
                CreatePostsCommentResponseNewMessageDataReactionReaction.Thumbsup => "thumbsup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePostsCommentResponseNewMessageDataReactionReaction? ToEnum(string value)
        {
            return value switch
            {
                "brain" => CreatePostsCommentResponseNewMessageDataReactionReaction.Brain,
                "cool" => CreatePostsCommentResponseNewMessageDataReactionReaction.Cool,
                "eyes" => CreatePostsCommentResponseNewMessageDataReactionReaction.Eyes,
                "fire" => CreatePostsCommentResponseNewMessageDataReactionReaction.Fire,
                "handshake" => CreatePostsCommentResponseNewMessageDataReactionReaction.Handshake,
                "heart" => CreatePostsCommentResponseNewMessageDataReactionReaction.Heart,
                "hugs" => CreatePostsCommentResponseNewMessageDataReactionReaction.Hugs,
                "mindblown" => CreatePostsCommentResponseNewMessageDataReactionReaction.Mindblown,
                "plus" => CreatePostsCommentResponseNewMessageDataReactionReaction.Plus,
                "rocket" => CreatePostsCommentResponseNewMessageDataReactionReaction.Rocket,
                "sad" => CreatePostsCommentResponseNewMessageDataReactionReaction.Sad,
                "thumbsup" => CreatePostsCommentResponseNewMessageDataReactionReaction.Thumbsup,
                _ => null,
            };
        }
    }
}