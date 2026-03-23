
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentReplyResponseNewMessageDataReactionReaction
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
    public static class CreateBlogCommentReplyResponseNewMessageDataReactionReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentReplyResponseNewMessageDataReactionReaction value)
        {
            return value switch
            {
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Brain => "brain",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Cool => "cool",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Eyes => "eyes",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Fire => "fire",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Handshake => "handshake",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Heart => "heart",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Hugs => "hugs",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Mindblown => "mindblown",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Plus => "plus",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Rocket => "rocket",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Sad => "sad",
                CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Thumbsup => "thumbsup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentReplyResponseNewMessageDataReactionReaction? ToEnum(string value)
        {
            return value switch
            {
                "brain" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Brain,
                "cool" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Cool,
                "eyes" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Eyes,
                "fire" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Fire,
                "handshake" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Handshake,
                "heart" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Heart,
                "hugs" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Hugs,
                "mindblown" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Mindblown,
                "plus" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Plus,
                "rocket" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Rocket,
                "sad" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Sad,
                "thumbsup" => CreateBlogCommentReplyResponseNewMessageDataReactionReaction.Thumbsup,
                _ => null,
            };
        }
    }
}