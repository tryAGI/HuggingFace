
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateDiscussionsCommentResponseNewMessageDataReactionReaction
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
    public static class CreateDiscussionsCommentResponseNewMessageDataReactionReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDiscussionsCommentResponseNewMessageDataReactionReaction value)
        {
            return value switch
            {
                CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Brain => "brain",
                CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Cool => "cool",
                CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Eyes => "eyes",
                CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Fire => "fire",
                CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Handshake => "handshake",
                CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Heart => "heart",
                CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Hugs => "hugs",
                CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Mindblown => "mindblown",
                CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Plus => "plus",
                CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Rocket => "rocket",
                CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Sad => "sad",
                CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Thumbsup => "thumbsup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDiscussionsCommentResponseNewMessageDataReactionReaction? ToEnum(string value)
        {
            return value switch
            {
                "brain" => CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Brain,
                "cool" => CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Cool,
                "eyes" => CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Eyes,
                "fire" => CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Fire,
                "handshake" => CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Handshake,
                "heart" => CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Heart,
                "hugs" => CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Hugs,
                "mindblown" => CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Mindblown,
                "plus" => CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Plus,
                "rocket" => CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Rocket,
                "sad" => CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Sad,
                "thumbsup" => CreateDiscussionsCommentResponseNewMessageDataReactionReaction.Thumbsup,
                _ => null,
            };
        }
    }
}