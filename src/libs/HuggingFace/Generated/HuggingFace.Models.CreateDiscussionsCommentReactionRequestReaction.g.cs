
#nullable enable

namespace HuggingFace
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateDiscussionsCommentReactionRequestReaction
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
    public static class CreateDiscussionsCommentReactionRequestReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsCommentReactionRequestReaction value)
        {
            return value switch
            {
                CreateDiscussionsCommentReactionRequestReaction.Brain => "brain",
                CreateDiscussionsCommentReactionRequestReaction.Cool => "cool",
                CreateDiscussionsCommentReactionRequestReaction.Eyes => "eyes",
                CreateDiscussionsCommentReactionRequestReaction.Fire => "fire",
                CreateDiscussionsCommentReactionRequestReaction.Handshake => "handshake",
                CreateDiscussionsCommentReactionRequestReaction.Heart => "heart",
                CreateDiscussionsCommentReactionRequestReaction.Hugs => "hugs",
                CreateDiscussionsCommentReactionRequestReaction.Mindblown => "mindblown",
                CreateDiscussionsCommentReactionRequestReaction.Plus => "plus",
                CreateDiscussionsCommentReactionRequestReaction.Rocket => "rocket",
                CreateDiscussionsCommentReactionRequestReaction.Sad => "sad",
                CreateDiscussionsCommentReactionRequestReaction.Thumbsup => "thumbsup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsCommentReactionRequestReaction? ToEnum(string value)
        {
            return value switch
            {
                "brain" => CreateDiscussionsCommentReactionRequestReaction.Brain,
                "cool" => CreateDiscussionsCommentReactionRequestReaction.Cool,
                "eyes" => CreateDiscussionsCommentReactionRequestReaction.Eyes,
                "fire" => CreateDiscussionsCommentReactionRequestReaction.Fire,
                "handshake" => CreateDiscussionsCommentReactionRequestReaction.Handshake,
                "heart" => CreateDiscussionsCommentReactionRequestReaction.Heart,
                "hugs" => CreateDiscussionsCommentReactionRequestReaction.Hugs,
                "mindblown" => CreateDiscussionsCommentReactionRequestReaction.Mindblown,
                "plus" => CreateDiscussionsCommentReactionRequestReaction.Plus,
                "rocket" => CreateDiscussionsCommentReactionRequestReaction.Rocket,
                "sad" => CreateDiscussionsCommentReactionRequestReaction.Sad,
                "thumbsup" => CreateDiscussionsCommentReactionRequestReaction.Thumbsup,
                _ => null,
            };
        }
    }
}