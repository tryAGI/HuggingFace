
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentResponseNewMessageDataReactionReaction2
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
    public static class CreateBlogCommentResponseNewMessageDataReactionReaction2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentResponseNewMessageDataReactionReaction2 value)
        {
            return value switch
            {
                CreateBlogCommentResponseNewMessageDataReactionReaction2.Brain => "brain",
                CreateBlogCommentResponseNewMessageDataReactionReaction2.Cool => "cool",
                CreateBlogCommentResponseNewMessageDataReactionReaction2.Eyes => "eyes",
                CreateBlogCommentResponseNewMessageDataReactionReaction2.Fire => "fire",
                CreateBlogCommentResponseNewMessageDataReactionReaction2.Handshake => "handshake",
                CreateBlogCommentResponseNewMessageDataReactionReaction2.Heart => "heart",
                CreateBlogCommentResponseNewMessageDataReactionReaction2.Hugs => "hugs",
                CreateBlogCommentResponseNewMessageDataReactionReaction2.Mindblown => "mindblown",
                CreateBlogCommentResponseNewMessageDataReactionReaction2.Plus => "plus",
                CreateBlogCommentResponseNewMessageDataReactionReaction2.Rocket => "rocket",
                CreateBlogCommentResponseNewMessageDataReactionReaction2.Sad => "sad",
                CreateBlogCommentResponseNewMessageDataReactionReaction2.Thumbsup => "thumbsup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentResponseNewMessageDataReactionReaction2? ToEnum(string value)
        {
            return value switch
            {
                "brain" => CreateBlogCommentResponseNewMessageDataReactionReaction2.Brain,
                "cool" => CreateBlogCommentResponseNewMessageDataReactionReaction2.Cool,
                "eyes" => CreateBlogCommentResponseNewMessageDataReactionReaction2.Eyes,
                "fire" => CreateBlogCommentResponseNewMessageDataReactionReaction2.Fire,
                "handshake" => CreateBlogCommentResponseNewMessageDataReactionReaction2.Handshake,
                "heart" => CreateBlogCommentResponseNewMessageDataReactionReaction2.Heart,
                "hugs" => CreateBlogCommentResponseNewMessageDataReactionReaction2.Hugs,
                "mindblown" => CreateBlogCommentResponseNewMessageDataReactionReaction2.Mindblown,
                "plus" => CreateBlogCommentResponseNewMessageDataReactionReaction2.Plus,
                "rocket" => CreateBlogCommentResponseNewMessageDataReactionReaction2.Rocket,
                "sad" => CreateBlogCommentResponseNewMessageDataReactionReaction2.Sad,
                "thumbsup" => CreateBlogCommentResponseNewMessageDataReactionReaction2.Thumbsup,
                _ => null,
            };
        }
    }
}