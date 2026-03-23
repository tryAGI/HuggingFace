
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentReplyResponseNewMessageDataHiddenReason
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
    public static class CreateBlogCommentReplyResponseNewMessageDataHiddenReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentReplyResponseNewMessageDataHiddenReason value)
        {
            return value switch
            {
                CreateBlogCommentReplyResponseNewMessageDataHiddenReason.Abuse => "Abuse",
                CreateBlogCommentReplyResponseNewMessageDataHiddenReason.GraphicContent => "Graphic Content",
                CreateBlogCommentReplyResponseNewMessageDataHiddenReason.OffTopic => "Off-Topic",
                CreateBlogCommentReplyResponseNewMessageDataHiddenReason.Resolved => "Resolved",
                CreateBlogCommentReplyResponseNewMessageDataHiddenReason.Spam => "Spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentReplyResponseNewMessageDataHiddenReason? ToEnum(string value)
        {
            return value switch
            {
                "Abuse" => CreateBlogCommentReplyResponseNewMessageDataHiddenReason.Abuse,
                "Graphic Content" => CreateBlogCommentReplyResponseNewMessageDataHiddenReason.GraphicContent,
                "Off-Topic" => CreateBlogCommentReplyResponseNewMessageDataHiddenReason.OffTopic,
                "Resolved" => CreateBlogCommentReplyResponseNewMessageDataHiddenReason.Resolved,
                "Spam" => CreateBlogCommentReplyResponseNewMessageDataHiddenReason.Spam,
                _ => null,
            };
        }
    }
}