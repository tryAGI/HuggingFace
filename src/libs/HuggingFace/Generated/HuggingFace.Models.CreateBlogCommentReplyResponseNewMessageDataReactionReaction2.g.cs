
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentReplyResponseNewMessageDataReactionReaction2
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
    public static class CreateBlogCommentReplyResponseNewMessageDataReactionReaction2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentReplyResponseNewMessageDataReactionReaction2 value)
        {
            return value switch
            {
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Brain => "brain",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Cool => "cool",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Eyes => "eyes",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Fire => "fire",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Handshake => "handshake",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Heart => "heart",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Hugs => "hugs",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Mindblown => "mindblown",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Plus => "plus",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Rocket => "rocket",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Sad => "sad",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Thumbsup => "thumbsup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentReplyResponseNewMessageDataReactionReaction2? ToEnum(string value)
        {
            return value switch
            {
                "brain" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Brain,
                "cool" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Cool,
                "eyes" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Eyes,
                "fire" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Fire,
                "handshake" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Handshake,
                "heart" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Heart,
                "hugs" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Hugs,
                "mindblown" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Mindblown,
                "plus" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Plus,
                "rocket" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Rocket,
                "sad" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Sad,
                "thumbsup" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction2.Thumbsup,
                _ => null,
            };
        }
    }
}