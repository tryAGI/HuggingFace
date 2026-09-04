
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreatePostsCommentReactionRequestReaction
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
    public static class CreatePostsCommentReactionRequestReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePostsCommentReactionRequestReaction value)
        {
            return value switch
            {
                CreatePostsCommentReactionRequestReaction.Brain => "brain",
                CreatePostsCommentReactionRequestReaction.Cool => "cool",
                CreatePostsCommentReactionRequestReaction.Eyes => "eyes",
                CreatePostsCommentReactionRequestReaction.Fire => "fire",
                CreatePostsCommentReactionRequestReaction.Handshake => "handshake",
                CreatePostsCommentReactionRequestReaction.Heart => "heart",
                CreatePostsCommentReactionRequestReaction.Hugs => "hugs",
                CreatePostsCommentReactionRequestReaction.Mindblown => "mindblown",
                CreatePostsCommentReactionRequestReaction.Plus => "plus",
                CreatePostsCommentReactionRequestReaction.Rocket => "rocket",
                CreatePostsCommentReactionRequestReaction.Sad => "sad",
                CreatePostsCommentReactionRequestReaction.Thumbsup => "thumbsup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePostsCommentReactionRequestReaction? ToEnum(string value)
        {
            return value switch
            {
                "brain" => CreatePostsCommentReactionRequestReaction.Brain,
                "cool" => CreatePostsCommentReactionRequestReaction.Cool,
                "eyes" => CreatePostsCommentReactionRequestReaction.Eyes,
                "fire" => CreatePostsCommentReactionRequestReaction.Fire,
                "handshake" => CreatePostsCommentReactionRequestReaction.Handshake,
                "heart" => CreatePostsCommentReactionRequestReaction.Heart,
                "hugs" => CreatePostsCommentReactionRequestReaction.Hugs,
                "mindblown" => CreatePostsCommentReactionRequestReaction.Mindblown,
                "plus" => CreatePostsCommentReactionRequestReaction.Plus,
                "rocket" => CreatePostsCommentReactionRequestReaction.Rocket,
                "sad" => CreatePostsCommentReactionRequestReaction.Sad,
                "thumbsup" => CreatePostsCommentReactionRequestReaction.Thumbsup,
                _ => null,
            };
        }
    }
}