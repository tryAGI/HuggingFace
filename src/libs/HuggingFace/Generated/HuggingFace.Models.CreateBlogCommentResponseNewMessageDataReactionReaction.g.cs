
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentResponseNewMessageDataReactionReaction
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
    public static class CreateBlogCommentResponseNewMessageDataReactionReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentResponseNewMessageDataReactionReaction value)
        {
            return value switch
            {
                CreateBlogCommentResponseNewMessageDataReactionReaction.Brain => "brain",
                CreateBlogCommentResponseNewMessageDataReactionReaction.Cool => "cool",
                CreateBlogCommentResponseNewMessageDataReactionReaction.Eyes => "eyes",
                CreateBlogCommentResponseNewMessageDataReactionReaction.Fire => "fire",
                CreateBlogCommentResponseNewMessageDataReactionReaction.Handshake => "handshake",
                CreateBlogCommentResponseNewMessageDataReactionReaction.Heart => "heart",
                CreateBlogCommentResponseNewMessageDataReactionReaction.Hugs => "hugs",
                CreateBlogCommentResponseNewMessageDataReactionReaction.Mindblown => "mindblown",
                CreateBlogCommentResponseNewMessageDataReactionReaction.Plus => "plus",
                CreateBlogCommentResponseNewMessageDataReactionReaction.Rocket => "rocket",
                CreateBlogCommentResponseNewMessageDataReactionReaction.Sad => "sad",
                CreateBlogCommentResponseNewMessageDataReactionReaction.Thumbsup => "thumbsup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentResponseNewMessageDataReactionReaction? ToEnum(string value)
        {
            return value switch
            {
                "brain" => CreateBlogCommentResponseNewMessageDataReactionReaction.Brain,
                "cool" => CreateBlogCommentResponseNewMessageDataReactionReaction.Cool,
                "eyes" => CreateBlogCommentResponseNewMessageDataReactionReaction.Eyes,
                "fire" => CreateBlogCommentResponseNewMessageDataReactionReaction.Fire,
                "handshake" => CreateBlogCommentResponseNewMessageDataReactionReaction.Handshake,
                "heart" => CreateBlogCommentResponseNewMessageDataReactionReaction.Heart,
                "hugs" => CreateBlogCommentResponseNewMessageDataReactionReaction.Hugs,
                "mindblown" => CreateBlogCommentResponseNewMessageDataReactionReaction.Mindblown,
                "plus" => CreateBlogCommentResponseNewMessageDataReactionReaction.Plus,
                "rocket" => CreateBlogCommentResponseNewMessageDataReactionReaction.Rocket,
                "sad" => CreateBlogCommentResponseNewMessageDataReactionReaction.Sad,
                "thumbsup" => CreateBlogCommentResponseNewMessageDataReactionReaction.Thumbsup,
                _ => null,
            };
        }
    }
}