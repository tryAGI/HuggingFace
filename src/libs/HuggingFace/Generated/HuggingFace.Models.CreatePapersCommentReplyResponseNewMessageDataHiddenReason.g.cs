
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreatePapersCommentReplyResponseNewMessageDataHiddenReason
    {
        /// <summary>
        /// 
        /// </summary>
        Abuse,
        /// <summary>
        /// 
        /// </summary>
        GraphicContent,
        /// <summary>
        /// 
        /// </summary>
        OffTopic,
        /// <summary>
        /// 
        /// </summary>
        Resolved,
        /// <summary>
        /// 
        /// </summary>
        Spam,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePapersCommentReplyResponseNewMessageDataHiddenReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePapersCommentReplyResponseNewMessageDataHiddenReason value)
        {
            return value switch
            {
                CreatePapersCommentReplyResponseNewMessageDataHiddenReason.Abuse => "Abuse",
                CreatePapersCommentReplyResponseNewMessageDataHiddenReason.GraphicContent => "Graphic Content",
                CreatePapersCommentReplyResponseNewMessageDataHiddenReason.OffTopic => "Off-Topic",
                CreatePapersCommentReplyResponseNewMessageDataHiddenReason.Resolved => "Resolved",
                CreatePapersCommentReplyResponseNewMessageDataHiddenReason.Spam => "Spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePapersCommentReplyResponseNewMessageDataHiddenReason? ToEnum(string value)
        {
            return value switch
            {
                "Abuse" => CreatePapersCommentReplyResponseNewMessageDataHiddenReason.Abuse,
                "Graphic Content" => CreatePapersCommentReplyResponseNewMessageDataHiddenReason.GraphicContent,
                "Off-Topic" => CreatePapersCommentReplyResponseNewMessageDataHiddenReason.OffTopic,
                "Resolved" => CreatePapersCommentReplyResponseNewMessageDataHiddenReason.Resolved,
                "Spam" => CreatePapersCommentReplyResponseNewMessageDataHiddenReason.Spam,
                _ => null,
            };
        }
    }
}