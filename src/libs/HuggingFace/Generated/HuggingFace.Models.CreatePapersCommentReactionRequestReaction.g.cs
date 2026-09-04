
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreatePapersCommentReactionRequestReaction
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
    public static class CreatePapersCommentReactionRequestReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePapersCommentReactionRequestReaction value)
        {
            return value switch
            {
                CreatePapersCommentReactionRequestReaction.Brain => "brain",
                CreatePapersCommentReactionRequestReaction.Cool => "cool",
                CreatePapersCommentReactionRequestReaction.Eyes => "eyes",
                CreatePapersCommentReactionRequestReaction.Fire => "fire",
                CreatePapersCommentReactionRequestReaction.Handshake => "handshake",
                CreatePapersCommentReactionRequestReaction.Heart => "heart",
                CreatePapersCommentReactionRequestReaction.Hugs => "hugs",
                CreatePapersCommentReactionRequestReaction.Mindblown => "mindblown",
                CreatePapersCommentReactionRequestReaction.Plus => "plus",
                CreatePapersCommentReactionRequestReaction.Rocket => "rocket",
                CreatePapersCommentReactionRequestReaction.Sad => "sad",
                CreatePapersCommentReactionRequestReaction.Thumbsup => "thumbsup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePapersCommentReactionRequestReaction? ToEnum(string value)
        {
            return value switch
            {
                "brain" => CreatePapersCommentReactionRequestReaction.Brain,
                "cool" => CreatePapersCommentReactionRequestReaction.Cool,
                "eyes" => CreatePapersCommentReactionRequestReaction.Eyes,
                "fire" => CreatePapersCommentReactionRequestReaction.Fire,
                "handshake" => CreatePapersCommentReactionRequestReaction.Handshake,
                "heart" => CreatePapersCommentReactionRequestReaction.Heart,
                "hugs" => CreatePapersCommentReactionRequestReaction.Hugs,
                "mindblown" => CreatePapersCommentReactionRequestReaction.Mindblown,
                "plus" => CreatePapersCommentReactionRequestReaction.Plus,
                "rocket" => CreatePapersCommentReactionRequestReaction.Rocket,
                "sad" => CreatePapersCommentReactionRequestReaction.Sad,
                "thumbsup" => CreatePapersCommentReactionRequestReaction.Thumbsup,
                _ => null,
            };
        }
    }
}