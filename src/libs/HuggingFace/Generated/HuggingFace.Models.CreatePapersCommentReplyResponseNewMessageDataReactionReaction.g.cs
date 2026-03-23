
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePapersCommentReplyResponseNewMessageDataReactionReaction
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
    public static class CreatePapersCommentReplyResponseNewMessageDataReactionReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePapersCommentReplyResponseNewMessageDataReactionReaction value)
        {
            return value switch
            {
                CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Brain => "brain",
                CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Cool => "cool",
                CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Eyes => "eyes",
                CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Fire => "fire",
                CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Handshake => "handshake",
                CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Heart => "heart",
                CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Hugs => "hugs",
                CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Mindblown => "mindblown",
                CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Plus => "plus",
                CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Rocket => "rocket",
                CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Sad => "sad",
                CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Thumbsup => "thumbsup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePapersCommentReplyResponseNewMessageDataReactionReaction? ToEnum(string value)
        {
            return value switch
            {
                "brain" => CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Brain,
                "cool" => CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Cool,
                "eyes" => CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Eyes,
                "fire" => CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Fire,
                "handshake" => CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Handshake,
                "heart" => CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Heart,
                "hugs" => CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Hugs,
                "mindblown" => CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Mindblown,
                "plus" => CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Plus,
                "rocket" => CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Rocket,
                "sad" => CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Sad,
                "thumbsup" => CreatePapersCommentReplyResponseNewMessageDataReactionReaction.Thumbsup,
                _ => null,
            };
        }
    }
}