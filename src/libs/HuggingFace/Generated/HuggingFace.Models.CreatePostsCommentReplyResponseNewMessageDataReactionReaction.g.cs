
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePostsCommentReplyResponseNewMessageDataReactionReaction
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
    public static class CreatePostsCommentReplyResponseNewMessageDataReactionReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePostsCommentReplyResponseNewMessageDataReactionReaction value)
        {
            return value switch
            {
                CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Brain => "brain",
                CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Cool => "cool",
                CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Eyes => "eyes",
                CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Fire => "fire",
                CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Handshake => "handshake",
                CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Heart => "heart",
                CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Hugs => "hugs",
                CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Mindblown => "mindblown",
                CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Plus => "plus",
                CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Rocket => "rocket",
                CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Sad => "sad",
                CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Thumbsup => "thumbsup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePostsCommentReplyResponseNewMessageDataReactionReaction? ToEnum(string value)
        {
            return value switch
            {
                "brain" => CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Brain,
                "cool" => CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Cool,
                "eyes" => CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Eyes,
                "fire" => CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Fire,
                "handshake" => CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Handshake,
                "heart" => CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Heart,
                "hugs" => CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Hugs,
                "mindblown" => CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Mindblown,
                "plus" => CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Plus,
                "rocket" => CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Rocket,
                "sad" => CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Sad,
                "thumbsup" => CreatePostsCommentReplyResponseNewMessageDataReactionReaction.Thumbsup,
                _ => null,
            };
        }
    }
}