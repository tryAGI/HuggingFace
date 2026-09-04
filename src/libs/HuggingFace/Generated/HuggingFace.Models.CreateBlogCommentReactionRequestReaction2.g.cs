
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateBlogCommentReactionRequestReaction2
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
    public static class CreateBlogCommentReactionRequestReaction2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentReactionRequestReaction2 value)
        {
            return value switch
            {
                CreateBlogCommentReactionRequestReaction2.Brain => "brain",
                CreateBlogCommentReactionRequestReaction2.Cool => "cool",
                CreateBlogCommentReactionRequestReaction2.Eyes => "eyes",
                CreateBlogCommentReactionRequestReaction2.Fire => "fire",
                CreateBlogCommentReactionRequestReaction2.Handshake => "handshake",
                CreateBlogCommentReactionRequestReaction2.Heart => "heart",
                CreateBlogCommentReactionRequestReaction2.Hugs => "hugs",
                CreateBlogCommentReactionRequestReaction2.Mindblown => "mindblown",
                CreateBlogCommentReactionRequestReaction2.Plus => "plus",
                CreateBlogCommentReactionRequestReaction2.Rocket => "rocket",
                CreateBlogCommentReactionRequestReaction2.Sad => "sad",
                CreateBlogCommentReactionRequestReaction2.Thumbsup => "thumbsup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentReactionRequestReaction2? ToEnum(string value)
        {
            return value switch
            {
                "brain" => CreateBlogCommentReactionRequestReaction2.Brain,
                "cool" => CreateBlogCommentReactionRequestReaction2.Cool,
                "eyes" => CreateBlogCommentReactionRequestReaction2.Eyes,
                "fire" => CreateBlogCommentReactionRequestReaction2.Fire,
                "handshake" => CreateBlogCommentReactionRequestReaction2.Handshake,
                "heart" => CreateBlogCommentReactionRequestReaction2.Heart,
                "hugs" => CreateBlogCommentReactionRequestReaction2.Hugs,
                "mindblown" => CreateBlogCommentReactionRequestReaction2.Mindblown,
                "plus" => CreateBlogCommentReactionRequestReaction2.Plus,
                "rocket" => CreateBlogCommentReactionRequestReaction2.Rocket,
                "sad" => CreateBlogCommentReactionRequestReaction2.Sad,
                "thumbsup" => CreateBlogCommentReactionRequestReaction2.Thumbsup,
                _ => null,
            };
        }
    }
}