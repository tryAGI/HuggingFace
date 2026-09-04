
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateBlogCommentReactionRequestReaction
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
    public static class CreateBlogCommentReactionRequestReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentReactionRequestReaction value)
        {
            return value switch
            {
                CreateBlogCommentReactionRequestReaction.Brain => "brain",
                CreateBlogCommentReactionRequestReaction.Cool => "cool",
                CreateBlogCommentReactionRequestReaction.Eyes => "eyes",
                CreateBlogCommentReactionRequestReaction.Fire => "fire",
                CreateBlogCommentReactionRequestReaction.Handshake => "handshake",
                CreateBlogCommentReactionRequestReaction.Heart => "heart",
                CreateBlogCommentReactionRequestReaction.Hugs => "hugs",
                CreateBlogCommentReactionRequestReaction.Mindblown => "mindblown",
                CreateBlogCommentReactionRequestReaction.Plus => "plus",
                CreateBlogCommentReactionRequestReaction.Rocket => "rocket",
                CreateBlogCommentReactionRequestReaction.Sad => "sad",
                CreateBlogCommentReactionRequestReaction.Thumbsup => "thumbsup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentReactionRequestReaction? ToEnum(string value)
        {
            return value switch
            {
                "brain" => CreateBlogCommentReactionRequestReaction.Brain,
                "cool" => CreateBlogCommentReactionRequestReaction.Cool,
                "eyes" => CreateBlogCommentReactionRequestReaction.Eyes,
                "fire" => CreateBlogCommentReactionRequestReaction.Fire,
                "handshake" => CreateBlogCommentReactionRequestReaction.Handshake,
                "heart" => CreateBlogCommentReactionRequestReaction.Heart,
                "hugs" => CreateBlogCommentReactionRequestReaction.Hugs,
                "mindblown" => CreateBlogCommentReactionRequestReaction.Mindblown,
                "plus" => CreateBlogCommentReactionRequestReaction.Plus,
                "rocket" => CreateBlogCommentReactionRequestReaction.Rocket,
                "sad" => CreateBlogCommentReactionRequestReaction.Sad,
                "thumbsup" => CreateBlogCommentReactionRequestReaction.Thumbsup,
                _ => null,
            };
        }
    }
}