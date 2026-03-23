
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePapersCommentResponseNewMessageDataReactionReaction
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
    public static class CreatePapersCommentResponseNewMessageDataReactionReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePapersCommentResponseNewMessageDataReactionReaction value)
        {
            return value switch
            {
                CreatePapersCommentResponseNewMessageDataReactionReaction.Brain => "brain",
                CreatePapersCommentResponseNewMessageDataReactionReaction.Cool => "cool",
                CreatePapersCommentResponseNewMessageDataReactionReaction.Eyes => "eyes",
                CreatePapersCommentResponseNewMessageDataReactionReaction.Fire => "fire",
                CreatePapersCommentResponseNewMessageDataReactionReaction.Handshake => "handshake",
                CreatePapersCommentResponseNewMessageDataReactionReaction.Heart => "heart",
                CreatePapersCommentResponseNewMessageDataReactionReaction.Hugs => "hugs",
                CreatePapersCommentResponseNewMessageDataReactionReaction.Mindblown => "mindblown",
                CreatePapersCommentResponseNewMessageDataReactionReaction.Plus => "plus",
                CreatePapersCommentResponseNewMessageDataReactionReaction.Rocket => "rocket",
                CreatePapersCommentResponseNewMessageDataReactionReaction.Sad => "sad",
                CreatePapersCommentResponseNewMessageDataReactionReaction.Thumbsup => "thumbsup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePapersCommentResponseNewMessageDataReactionReaction? ToEnum(string value)
        {
            return value switch
            {
                "brain" => CreatePapersCommentResponseNewMessageDataReactionReaction.Brain,
                "cool" => CreatePapersCommentResponseNewMessageDataReactionReaction.Cool,
                "eyes" => CreatePapersCommentResponseNewMessageDataReactionReaction.Eyes,
                "fire" => CreatePapersCommentResponseNewMessageDataReactionReaction.Fire,
                "handshake" => CreatePapersCommentResponseNewMessageDataReactionReaction.Handshake,
                "heart" => CreatePapersCommentResponseNewMessageDataReactionReaction.Heart,
                "hugs" => CreatePapersCommentResponseNewMessageDataReactionReaction.Hugs,
                "mindblown" => CreatePapersCommentResponseNewMessageDataReactionReaction.Mindblown,
                "plus" => CreatePapersCommentResponseNewMessageDataReactionReaction.Plus,
                "rocket" => CreatePapersCommentResponseNewMessageDataReactionReaction.Rocket,
                "sad" => CreatePapersCommentResponseNewMessageDataReactionReaction.Sad,
                "thumbsup" => CreatePapersCommentResponseNewMessageDataReactionReaction.Thumbsup,
                _ => null,
            };
        }
    }
}