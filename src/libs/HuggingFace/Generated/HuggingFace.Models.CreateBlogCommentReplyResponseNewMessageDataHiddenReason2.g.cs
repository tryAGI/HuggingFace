
#nullable enable

namespace HuggingFace
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateBlogCommentReplyResponseNewMessageDataHiddenReason2
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
        LowQuality,
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
    public static class CreateBlogCommentReplyResponseNewMessageDataHiddenReason2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateBlogCommentReplyResponseNewMessageDataHiddenReason2 value)
        {
            return value switch
            {
                CreateBlogCommentReplyResponseNewMessageDataHiddenReason2.Abuse => "Abuse",
                CreateBlogCommentReplyResponseNewMessageDataHiddenReason2.GraphicContent => "Graphic Content",
                CreateBlogCommentReplyResponseNewMessageDataHiddenReason2.LowQuality => "Low Quality",
                CreateBlogCommentReplyResponseNewMessageDataHiddenReason2.OffTopic => "Off-Topic",
                CreateBlogCommentReplyResponseNewMessageDataHiddenReason2.Resolved => "Resolved",
                CreateBlogCommentReplyResponseNewMessageDataHiddenReason2.Spam => "Spam",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateBlogCommentReplyResponseNewMessageDataHiddenReason2? ToEnum(string value)
        {
            return value switch
            {
                "Abuse" => CreateBlogCommentReplyResponseNewMessageDataHiddenReason2.Abuse,
                "Graphic Content" => CreateBlogCommentReplyResponseNewMessageDataHiddenReason2.GraphicContent,
                "Low Quality" => CreateBlogCommentReplyResponseNewMessageDataHiddenReason2.LowQuality,
                "Off-Topic" => CreateBlogCommentReplyResponseNewMessageDataHiddenReason2.OffTopic,
                "Resolved" => CreateBlogCommentReplyResponseNewMessageDataHiddenReason2.Resolved,
                "Spam" => CreateBlogCommentReplyResponseNewMessageDataHiddenReason2.Spam,
                _ => null,
            };
        }
    }
}